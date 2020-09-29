namespace Saludo
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.txResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btPunto = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txResultado
            // 
            this.txResultado.Location = new System.Drawing.Point(12, 22);
            this.txResultado.Name = "txResultado";
            this.txResultado.Size = new System.Drawing.Size(271, 29);
            this.txResultado.TabIndex = 0;
            this.txResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(75, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(75, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 31);
            this.button8.TabIndex = 8;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(138, 159);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 31);
            this.button9.TabIndex = 9;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btPunto
            // 
            this.btPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPunto.Location = new System.Drawing.Point(13, 196);
            this.btPunto.Name = "btPunto";
            this.btPunto.Size = new System.Drawing.Size(57, 32);
            this.btPunto.TabIndex = 10;
            this.btPunto.Text = ".";
            this.btPunto.UseVisualStyleBackColor = true;
            this.btPunto.Click += new System.EventHandler(this.btPunto_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(75, 196);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(57, 32);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btIgual.Location = new System.Drawing.Point(138, 196);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(57, 32);
            this.btIgual.TabIndex = 12;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btSuma
            // 
            this.btSuma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuma.Location = new System.Drawing.Point(217, 78);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(57, 35);
            this.btSuma.TabIndex = 13;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = false;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btResta
            // 
            this.btResta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResta.Location = new System.Drawing.Point(217, 119);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(57, 34);
            this.btResta.TabIndex = 14;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = false;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // btMult
            // 
            this.btMult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(217, 159);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(57, 31);
            this.btMult.TabIndex = 15;
            this.btMult.Text = "*";
            this.btMult.UseVisualStyleBackColor = false;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDivision
            // 
            this.btDivision.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.Location = new System.Drawing.Point(217, 196);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(57, 32);
            this.btDivision.TabIndex = 16;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = false;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 240);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btPunto);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txResultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btPunto;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}