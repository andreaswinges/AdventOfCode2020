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
    public partial class FormDayChooser : Form
    {
        private DayForms _dayForms;
        public FormDayChooser()
        {
            InitializeComponent();
        }

        private void FormDayChooser_Load(object sender, EventArgs e)
        {
            _dayForms = new DayForms();
            foreach (var item in _dayForms.listofforms)
            {
                CB_Days.Items.Add(item.Name);
            }
        }

        private class FormsCB
        {
            public Form form { get; set; }
            public string Name { get; set; }

            public FormsCB(Form inform)
            {
                form = inform;
                Name = inform.Text;
            }
        }

        private class DayForms
        {
            Type[] screenTypes = new Type[] {
                typeof(FormDayOne),
                typeof(FormDayTwo),
                typeof(FormDayThree),
                typeof(FormDayFour),
            };

            public List<FormsCB> listofforms = new List<FormsCB>();

            public DayForms()
            {
                foreach (var formtype in screenTypes)
                {
                    var formCB = new FormsCB((Form)Activator.CreateInstance(formtype));
                    listofforms.Add(formCB);
                }
            }
        }

        private void BTN_ChooseDay_Click(object sender, EventArgs e)
        {
            var name = (string)CB_Days.SelectedItem;

            Form form = _dayForms.listofforms.Single(s => s.Name == name).form;

            form.ShowDialog();
        }
    }
}
