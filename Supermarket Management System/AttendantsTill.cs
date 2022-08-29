using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class AttendantsTill : Form
    {
        System.Timers.Timer timer;
        int hours, mins, secs;

        public AttendantsTill()
        {
            InitializeComponent();
        }
        private void AttendantsTill_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                secs += 1;
                if (secs == 60)
                {
                    secs = 0;
                    mins += 1;
                }
                if (mins == 60)
                {
                    mins = 0;
                    hours += 1;
                }
                TimerBox.Text = string.Format("{0}:{1}:{2}", hours.ToString().PadLeft(2, '0'), mins.ToString().PadLeft(2, '0'), secs.ToString().PadLeft(2, '0'));
            }
            ));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
