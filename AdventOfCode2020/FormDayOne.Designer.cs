namespace AdventOfCode2020
{
    partial class FormDayOne
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
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.BTN_Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_PartOne = new System.Windows.Forms.TextBox();
            this.TB_PartTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(12, 12);
            this.TB_Input.Multiline = true;
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(633, 430);
            this.TB_Input.TabIndex = 0;
            // 
            // BTN_Run
            // 
            this.BTN_Run.Location = new System.Drawing.Point(1010, 580);
            this.BTN_Run.Name = "BTN_Run";
            this.BTN_Run.Size = new System.Drawing.Size(167, 81);
            this.BTN_Run.TabIndex = 1;
            this.BTN_Run.Text = "Run";
            this.BTN_Run.UseVisualStyleBackColor = true;
            this.BTN_Run.Click += new System.EventHandler(this.BTN_Run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result Part 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result Part 2:";
            // 
            // TB_PartOne
            // 
            this.TB_PartOne.Location = new System.Drawing.Point(186, 576);
            this.TB_PartOne.Name = "TB_PartOne";
            this.TB_PartOne.Size = new System.Drawing.Size(251, 29);
            this.TB_PartOne.TabIndex = 6;
            // 
            // TB_PartTwo
            // 
            this.TB_PartTwo.Location = new System.Drawing.Point(186, 611);
            this.TB_PartTwo.Name = "TB_PartTwo";
            this.TB_PartTwo.Size = new System.Drawing.Size(251, 29);
            this.TB_PartTwo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 673);
            this.Controls.Add(this.TB_PartTwo);
            this.Controls.Add(this.TB_PartOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Run);
            this.Controls.Add(this.TB_Input);
            this.Name = "Form1";
            this.Text = "Day One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button BTN_Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_PartOne;
        private System.Windows.Forms.TextBox TB_PartTwo;
    }
}

