using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*This is an Egg timer. The user can eneter a time to start from or it will 
start from the default 03:00. The user cannot enter a non interger digit.*/

namespace EggTimer {
    public partial class EggTimerForm : Form {

        private TimeSpan remainingTime;

        public EggTimerForm() {
            InitializeComponent();
        }

        private void EggTimerForm_Load(object sender, EventArgs e) {

        }

        private void actionButton_Click(object sender, EventArgs e) {
            if(actionButton.Text == "Start") {
                StartTimer();
            } else if (actionButton.Text == "Reset") {
                ReinitialiseTimer();
            } else {
                StopTimer();
            }
            
        }
        private void StartTimer() {
            timer.Start();  // this timer on it's own will tick but it is ot yet link to the GUI.

            string[] minutesAndSceonds = timeTextBox.Text.Split(':');
            remainingTime = new TimeSpan(0, int.Parse(minutesAndSceonds[0]), int.Parse(minutesAndSceonds[1]));

            timer.Start();
            actionButton.Text = "Stop";

        }

        private void timer_Tick(object sender, EventArgs e) {
            // subtract one second
            remainingTime = remainingTime.Subtract(new TimeSpan(0, 0, 1));

            //Any time Left?
            if(remainingTime.TotalSeconds > 0) {
                timeTextBox.Text = remainingTime.ToString(@"mm\:ss");
            } else {
                TimerIsFinished();
            }
        }
        private void TimerIsFinished() {
            timer.Stop();
            timeTextBox.Text = "-00:00-";
            actionButton.Text = "Reset";
        }
        private void ReinitialiseTimer() {
            timeTextBox.Text = "03:00";
            actionButton.Text = "Start";
        }
        private void StopTimer() {
            timer.Stop();
            actionButton.Text = "Start";
        }

        private void timeTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == ':' && !timeTextBox.Text.Contains(':'))) {
                // do nothing, leting the KeyChar be processed as normal.
            } else {
                e.Handled = true;
            }
        }
    }
}
