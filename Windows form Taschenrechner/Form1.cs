using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                label1.Text = "-";
                label3.Text = (x - y).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler!!!!!¨¨");
            }
        }

        private void buttonGeteilt_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            label1.Text = "/";
            if(y==0)
            {
                label3.Text = " error";         
            }
            else
            label3.Text = (x / y).ToString();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                label1.Text = "+";
                label3.Text = (x + y).ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler!!!!!¨¨");
            }
        }

        private void buttonMal_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            label1.Text = "X";
            label3.Text = (x * y).ToString();

        }
    }
}
