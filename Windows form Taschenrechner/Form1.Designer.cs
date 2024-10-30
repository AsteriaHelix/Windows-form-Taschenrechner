namespace Windows_form_Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonGeteilt = new System.Windows.Forms.Button();
            this.buttonMal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 56);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(695, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 56);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1037, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1177, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonPlus.Location = new System.Drawing.Point(81, 328);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(153, 67);
            this.buttonPlus.TabIndex = 5;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonMinus.Location = new System.Drawing.Point(81, 427);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(153, 67);
            this.buttonMinus.TabIndex = 6;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonGeteilt
            // 
            this.buttonGeteilt.BackColor = System.Drawing.Color.Purple;
            this.buttonGeteilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeteilt.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonGeteilt.Location = new System.Drawing.Point(81, 617);
            this.buttonGeteilt.Name = "buttonGeteilt";
            this.buttonGeteilt.Size = new System.Drawing.Size(153, 67);
            this.buttonGeteilt.TabIndex = 7;
            this.buttonGeteilt.Text = ":";
            this.buttonGeteilt.UseVisualStyleBackColor = false;
            this.buttonGeteilt.Click += new System.EventHandler(this.buttonGeteilt_Click);
            // 
            // buttonMal
            // 
            this.buttonMal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMal.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonMal.Location = new System.Drawing.Point(81, 528);
            this.buttonMal.Name = "buttonMal";
            this.buttonMal.Size = new System.Drawing.Size(153, 67);
            this.buttonMal.TabIndex = 8;
            this.buttonMal.Text = "x";
            this.buttonMal.UseVisualStyleBackColor = false;
            this.buttonMal.Click += new System.EventHandler(this.buttonMal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_form_Taschenrechner.Properties.Resources.depositphotos_43211163_stock_illustration_seamless_background_electronic_calculator;
            this.ClientSize = new System.Drawing.Size(1729, 770);
            this.Controls.Add(this.buttonMal);
            this.Controls.Add(this.buttonGeteilt);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonGeteilt;
        private System.Windows.Forms.Button buttonMal;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
    }
}

