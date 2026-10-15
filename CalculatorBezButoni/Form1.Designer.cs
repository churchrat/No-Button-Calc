namespace CalculatorBezButoni
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            rbPlus = new RadioButton();
            rbMinus = new RadioButton();
            rbMult = new RadioButton();
            rbDiv = new RadioButton();
            textBox3 = new TextBox();
            rbPower = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(54, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // rbPlus
            // 
            rbPlus.AutoSize = true;
            rbPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbPlus.Location = new Point(12, 76);
            rbPlus.Name = "rbPlus";
            rbPlus.Size = new Size(45, 34);
            rbPlus.TabIndex = 2;
            rbPlus.TabStop = true;
            rbPlus.Text = "+";
            rbPlus.UseVisualStyleBackColor = true;
            rbPlus.CheckedChanged += rbPlus_CheckedChanged;
            // 
            // rbMinus
            // 
            rbMinus.AutoSize = true;
            rbMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbMinus.Location = new Point(12, 116);
            rbMinus.Name = "rbMinus";
            rbMinus.Size = new Size(39, 34);
            rbMinus.TabIndex = 3;
            rbMinus.TabStop = true;
            rbMinus.Text = "-";
            rbMinus.UseVisualStyleBackColor = true;
            rbMinus.CheckedChanged += rbMinus_CheckedChanged;
            // 
            // rbMult
            // 
            rbMult.AutoSize = true;
            rbMult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbMult.Location = new Point(72, 76);
            rbMult.Name = "rbMult";
            rbMult.Size = new Size(40, 34);
            rbMult.TabIndex = 4;
            rbMult.TabStop = true;
            rbMult.Text = "*";
            rbMult.UseVisualStyleBackColor = true;
            rbMult.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rbDiv
            // 
            rbDiv.AutoSize = true;
            rbDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbDiv.Location = new Point(72, 116);
            rbDiv.Name = "rbDiv";
            rbDiv.Size = new Size(39, 34);
            rbDiv.TabIndex = 5;
            rbDiv.TabStop = true;
            rbDiv.Tag = "";
            rbDiv.Text = "/";
            rbDiv.UseVisualStyleBackColor = true;
            rbDiv.CheckedChanged += rbDiv_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 41);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // rbPower
            // 
            rbPower.AutoSize = true;
            rbPower.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbPower.Location = new Point(12, 156);
            rbPower.Name = "rbPower";
            rbPower.Size = new Size(45, 34);
            rbPower.TabIndex = 8;
            rbPower.TabStop = true;
            rbPower.Text = "^";
            rbPower.UseVisualStyleBackColor = true;
            rbPower.CheckedChanged += rbPower_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(122, 200);
            Controls.Add(rbPower);
            Controls.Add(textBox3);
            Controls.Add(rbDiv);
            Controls.Add(rbMult);
            Controls.Add(rbMinus);
            Controls.Add(rbPlus);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "No Button Calc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton rbPlus;
        private RadioButton rbMinus;
        private RadioButton rbMult;
        private RadioButton rbDiv;
        private TextBox textBox3;
        private RadioButton rbPower;
    }
}
