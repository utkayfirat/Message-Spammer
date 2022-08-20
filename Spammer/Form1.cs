using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spammer
{
    public partial class Form1 : Form
    {

        bool startOrClose = true;
        bool firstEnter = false;

        public Form1(){
            InitializeComponent();
            intervalTextBox.Value = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e){
            if(firstEnter)
                SendKeys.Send("{ENTER}");
            SendKeys.Send(messageTextBox.Text);
            SendKeys.Send("{ENTER}");
        }

        private void startBotButton_Click(object sender, EventArgs e){
            if(intervalTextBox.Value <= 0) {
                MessageBox.Show("Please enter interval!");
                return;
            }

            timer1.Interval = (int)intervalTextBox.Value;
            if (startOrClose) {
                timer1.Start();
                startBotButton.Text = "Close";
                startBotButton.BackColor = Color.DarkRed;
                
            }
            else {
                timer1.Stop();
                startBotButton.Text = "Start";
                startBotButton.BackColor = Color.Black;
            }

            startOrClose = !startOrClose;
        }

        private void firstEnterCheckBox_CheckedChanged(object sender, EventArgs e){
            firstEnter = firstEnterCheckBox.Checked;
            if (firstEnter)
                firstEnterCheckBox.Text = "First-Enter (ONLINE)";
            else
                firstEnterCheckBox.Text = "First-Enter (OFFLINE)";
        }
    }
}
