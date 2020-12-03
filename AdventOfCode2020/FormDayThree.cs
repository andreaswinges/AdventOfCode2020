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
    public partial class FormDayThree : Form
    {
        public FormDayThree()
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
            long numberoftrees = GetTrees(inputArray, 1, 3);

            TB_PartOne.Text = numberoftrees.ToString();
        }

        private void PartTwo(string[] inputArray)
        {
            (int, int)[] slopes = new (int, int)[] { (1, 1), (1, 3), (1, 5), (1, 7), (2, 1) };
            long result = 1;

            foreach (var slope in slopes)
            {
                result *= GetTrees(inputArray, slope.Item1, slope.Item2);
            }

            TB_PartTwo.Text = result.ToString();
        }

        private static int GetTrees(string[] inputArray, int down, int rigth)
        {
            int currentstep = 0;
            int numberoftrees = 0;
            for (int i = down; i < inputArray.Length; i += down)
            {
                var currentrow = inputArray[i];
                currentstep = currentstep + rigth;
                while (currentrow.Length < currentstep + 1)
                {
                    currentrow = $"{currentrow}{currentrow}";
                }
                if (currentrow.Substring(currentstep, 1) == "#")
                {
                    numberoftrees++;
                }
            }

            return numberoftrees;
        }
    }
}
