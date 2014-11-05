namespace DS_LB1
{
    partial class Form1
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
            this.LblX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.Lblres = new System.Windows.Forms.Label();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.TxtBxX = new System.Windows.Forms.TextBox();
            this.TxtBxY = new System.Windows.Forms.TextBox();
            this.TxtBxRes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Location = new System.Drawing.Point(12, 26);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(59, 13);
            this.LblX.TabIndex = 0;
            this.LblX.Text = "Введите X";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Location = new System.Drawing.Point(12, 55);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(59, 13);
            this.LblY.TabIndex = 1;
            this.LblY.Text = "Введите Y";
            // 
            // Lblres
            // 
            this.Lblres.AutoSize = true;
            this.Lblres.Location = new System.Drawing.Point(12, 108);
            this.Lblres.Name = "Lblres";
            this.Lblres.Size = new System.Drawing.Size(59, 13);
            this.Lblres.TabIndex = 2;
            this.Lblres.Text = "Результат";
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.Location = new System.Drawing.Point(12, 211);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calc.TabIndex = 3;
            this.Btn_Calc.Text = "Проверка";
            this.Btn_Calc.UseVisualStyleBackColor = true;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.Location = new System.Drawing.Point(105, 211);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 23);
            this.Btn_close.TabIndex = 4;
            this.Btn_close.Text = "Выход";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // TxtBxX
            // 
            this.TxtBxX.Location = new System.Drawing.Point(80, 26);
            this.TxtBxX.Name = "TxtBxX";
            this.TxtBxX.Size = new System.Drawing.Size(100, 20);
            this.TxtBxX.TabIndex = 5;
            // 
            // TxtBxY
            // 
            this.TxtBxY.Location = new System.Drawing.Point(80, 55);
            this.TxtBxY.Name = "TxtBxY";
            this.TxtBxY.Size = new System.Drawing.Size(100, 20);
            this.TxtBxY.TabIndex = 6;
            // 
            // TxtBxRes
            // 
            this.TxtBxRes.Location = new System.Drawing.Point(80, 101);
            this.TxtBxRes.Name = "TxtBxRes";
            this.TxtBxRes.Size = new System.Drawing.Size(100, 20);
            this.TxtBxRes.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DS_LB1.Properties.Resources.Безымянный;
            this.pictureBox1.Location = new System.Drawing.Point(186, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtBxRes);
            this.Controls.Add(this.TxtBxY);
            this.Controls.Add(this.TxtBxX);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.Btn_Calc);
            this.Controls.Add(this.Lblres);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Label Lblres;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.TextBox TxtBxX;
        private System.Windows.Forms.TextBox TxtBxY;
        private System.Windows.Forms.TextBox TxtBxRes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

