using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class FormDayFour : Form
    {
        public FormDayFour()
        {
            InitializeComponent();
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            var inputArray = TB_Input.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            PartOne(inputArray);
            PartTwo(inputArray);
        }

        private void PartOne(string[] inputArray)
        {
            TB_PartOne.Text = "";
        }

        private void PartTwo(string[] inputArray)
        {

            TB_PartTwo.Text = "";
        }
    }
}
