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
    public partial class TimerForm : Form
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public TimerForm(int hours,int minutes,int seconds)
        {

            InitializeComponent();
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
            label1.Text = $"{GetRightString(_hours)}:{GetRightString(_minutes)}:{GetRightString(_seconds)}";
            timer1.Interval = 1000;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_seconds>0)
            {
                _seconds--;
            }
            else if(_minutes>0)
            {
                _minutes--;
                _seconds = 59;
            }
            else if(_hours>0)
            {
                _hours--;
                _minutes = 59;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("ВРЕМЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯ!!!!!", "Атэнш");
                Close();
            }           
            label1.Text = $"{GetRightString(_hours)}:{GetRightString(_minutes)}:{GetRightString(_seconds)}";

        }
        private  string GetRightString(int time)
        {
            if(time/10 == 0)
            {
                return $"0{time}";
            }
            return time.ToString();
        }
        private void TimerForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form start = Application.OpenForms[0];           
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
