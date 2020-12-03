namespace AdventOfCode2020
{
    partial class FormDayChooser
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
            this.CB_Days = new System.Windows.Forms.ComboBox();
            this.BTN_ChooseDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Days
            // 
            this.CB_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Days.FormattingEnabled = true;
            this.CB_Days.Location = new System.Drawing.Point(82, 64);
            this.CB_Days.Name = "CB_Days";
            this.CB_Days.Size = new System.Drawing.Size(663, 56);
            this.CB_Days.TabIndex = 0;
            // 
            // BTN_ChooseDay
            // 
            this.BTN_ChooseDay.Location = new System.Drawing.Point(664, 394);
            this.BTN_ChooseDay.Name = "BTN_ChooseDay";
            this.BTN_ChooseDay.Size = new System.Drawing.Size(228, 110);
            this.BTN_ChooseDay.TabIndex = 1;
            this.BTN_ChooseDay.Text = "Choose Day";
            this.BTN_ChooseDay.UseVisualStyleBackColor = true;
            this.BTN_ChooseDay.Click += new System.EventHandler(this.BTN_ChooseDay_Click);
            // 
            // FormDayChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 516);
            this.Controls.Add(this.BTN_ChooseDay);
            this.Controls.Add(this.CB_Days);
            this.Name = "FormDayChooser";
            this.Text = "FormDayChooser";
            this.Load += new System.EventHandler(this.FormDayChooser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Days;
        private System.Windows.Forms.Button BTN_ChooseDay;
    }
}