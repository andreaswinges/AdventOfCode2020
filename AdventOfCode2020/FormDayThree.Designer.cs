namespace AdventOfCode2020
{
    partial class FormDayThree
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
            this.TB_PartTwo = new System.Windows.Forms.TextBox();
            this.TB_PartOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Run = new System.Windows.Forms.Button();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_PartTwo
            // 
            this.TB_PartTwo.Location = new System.Drawing.Point(181, 617);
            this.TB_PartTwo.Name = "TB_PartTwo";
            this.TB_PartTwo.Size = new System.Drawing.Size(251, 29);
            this.TB_PartTwo.TabIndex = 19;
            // 
            // TB_PartOne
            // 
            this.TB_PartOne.Location = new System.Drawing.Point(181, 582);
            this.TB_PartOne.Name = "TB_PartOne";
            this.TB_PartOne.Size = new System.Drawing.Size(251, 29);
            this.TB_PartOne.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Result Part 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Result Part 1:";
            // 
            // BTN_Run
            // 
            this.BTN_Run.Location = new System.Drawing.Point(1005, 586);
            this.BTN_Run.Name = "BTN_Run";
            this.BTN_Run.Size = new System.Drawing.Size(167, 81);
            this.BTN_Run.TabIndex = 15;
            this.BTN_Run.Text = "Run";
            this.BTN_Run.UseVisualStyleBackColor = true;
            this.BTN_Run.Click += new System.EventHandler(this.BTN_Run_Click);
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(7, 18);
            this.TB_Input.Multiline = true;
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(633, 430);
            this.TB_Input.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 711);
            this.Controls.Add(this.TB_PartTwo);
            this.Controls.Add(this.TB_PartOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Run);
            this.Controls.Add(this.TB_Input);
            this.Name = "Form3";
            this.Text = "Day Three";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_PartTwo;
        private System.Windows.Forms.TextBox TB_PartOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Run;
        private System.Windows.Forms.TextBox TB_Input;
    }
}