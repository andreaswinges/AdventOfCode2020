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
    public partial class FormDayTwo : Form
    {
        public FormDayTwo()
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
            int numberofvalidpasswords = 0;

            foreach (var input in inputArray)
            {
                var splitedInput = input.Split(' ');
                var minmaxarray = splitedInput[0].Split('-');
                Int32.TryParse(minmaxarray[0], out int min);
                Int32.TryParse(minmaxarray[1], out int max);
                var character = splitedInput[1].Substring(0, 1).ToCharArray()[0];

                var numberofcharactersinstring = splitedInput[2].Count(c => c == character);

                if (numberofcharactersinstring >= min && numberofcharactersinstring <= max)
                {
                    numberofvalidpasswords++;
                }
            }

            TB_PartOne.Text = numberofvalidpasswords.ToString();
        }

        private void PartTwo(string[] inputArray)
        {
            int numberofvalidpasswords = 0;

            foreach (var input in inputArray)
            {
                var splitedInput = input.Split(' ');
                var posarray = splitedInput[0].Split('-');
                Int32.TryParse(posarray[0], out int pos1);
                Int32.TryParse(posarray[1], out int pos2);
                var character = splitedInput[1].Substring(0, 1);

                var pos1exist = splitedInput[2].Substring(pos1 - 1, 1) == character;

                var pos2exist = splitedInput[2].Substring(pos2 - 1, 1) == character;


                if ((pos1exist || pos2exist) && (!pos1exist || !pos2exist))
                {
                    numberofvalidpasswords++;
                }
            }

            TB_PartTwo.Text = numberofvalidpasswords.ToString();
        }
    }
}
