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
    public partial class FormDayOne : Form
    {
        public FormDayOne()
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
            foreach (var number in inputArray)
            {
                Int32.TryParse(number, out int intnumber);
                var NumberToFind = 2020 - intnumber;
                if (inputArray.Contains(NumberToFind.ToString()))
                {
                    TB_PartOne.Text = (intnumber * NumberToFind).ToString();
                    break;
                }
            }
        }

        private void PartTwo(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Int32.TryParse(inputArray[i], out int intnumber);
                for (int i2 = 0; i2 < inputArray.Length; i2++)
                {
                    if (i != i2)
                    {
                        Int32.TryParse(inputArray[i2], out int intnumber2);
                        if ((intnumber + intnumber2) < 2020)
                        {
                            for (int i3 = 0; i3 < inputArray.Length; i3++)
                            {
                                if (i != i3 && i2 != i3)
                                {
                                    Int32.TryParse(inputArray[i3], out int intnumber3);
                                    if ((intnumber + intnumber2 + intnumber3) == 2020)
                                    {
                                        TB_PartTwo.Text = (intnumber * intnumber2 * intnumber3).ToString();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
