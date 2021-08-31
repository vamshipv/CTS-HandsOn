
namespace WindowsFormsAppCalculator
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
            this.Addition = new System.Windows.Forms.RadioButton();
            this.Division = new System.Windows.Forms.RadioButton();
            this.Multiplication = new System.Windows.Forms.RadioButton();
            this.Subtraction = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Location = new System.Drawing.Point(207, 117);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(71, 19);
            this.Addition.TabIndex = 0;
            this.Addition.TabStop = true;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(484, 117);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(67, 19);
            this.Division.TabIndex = 1;
            this.Division.TabStop = true;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Multiplication
            // 
            this.Multiplication.AutoSize = true;
            this.Multiplication.Location = new System.Drawing.Point(384, 117);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(99, 19);
            this.Multiplication.TabIndex = 2;
            this.Multiplication.TabStop = true;
            this.Multiplication.Text = "Multiplication";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Subtraction
            // 
            this.Subtraction.AutoSize = true;
            this.Subtraction.Location = new System.Drawing.Point(284, 117);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(86, 19);
            this.Subtraction.TabIndex = 3;
            this.Subtraction.TabStop = true;
            this.Subtraction.Text = "Subtraction";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Addition;
        private System.Windows.Forms.RadioButton Division;
        private System.Windows.Forms.RadioButton Multiplication;
        private System.Windows.Forms.RadioButton Subtraction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

