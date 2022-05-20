using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainForm : Form
    {
        int _hours;
        int _minutes;
        int _seconds;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value >= 0 && numericUpDown2.Value>=0 && numericUpDown3.Value >= 0)
            {
                Hide();//метож show вызывается в другой форме
                _hours = (int)numericUpDown1.Value;
                _minutes= (int)numericUpDown2.Value;
                _seconds = (int)numericUpDown3.Value;
                TimerForm timer = new TimerForm(_hours,_minutes,_seconds);
                timer.Show();

            }
            else
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }
    }
}
