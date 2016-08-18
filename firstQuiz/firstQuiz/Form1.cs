using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstQuiz
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1true = false;
        bool q2true = false;
        bool q3true = false;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void q1answer1_CheckedChanged(object sender, EventArgs e)
        {
            if (q1answer1.Checked)
            {
                label3.ForeColor = Color.Red;
                // This is a cross
                label3.Text = "\u00fb";
                q1true = false;
            }
        }

        private void q1answer2_CheckedChanged(object sender, EventArgs e)
        {
            if (q1answer2.Checked)
            {
                label3.ForeColor = Color.Green;
                // This is a tick
                label3.Text = "\u00fc";
                q1true = true;
            }
        }

        private void q1answer3_CheckedChanged(object sender, EventArgs e)
        {
            if (q1answer3.Checked)
            {
                label3.ForeColor = Color.Red;
                // This is a cross
                label3.Text = "\u00fb";
                q1true = false;
            }
        }

        private void q2answer1_CheckedChanged(object sender, EventArgs e)
        {
            if (q2answer1.Checked)
            {
                label6.ForeColor = Color.Red;
                // This is a cross
                label6.Text = "\u00fb";
                q2true = false;
            }
        }

        private void q2answer2_CheckedChanged(object sender, EventArgs e)
        {
            if (q2answer2.Checked)
            {
                label6.ForeColor = Color.Red;
                // This is a cross
                label6.Text = "\u00fb";
                q2true = false;
            }
        }

        private void q2answer3_CheckedChanged(object sender, EventArgs e)
        {
            if (q2answer3.Checked)
            {
                label6.ForeColor = Color.Green;
                // This is a tick
                label6.Text = "\u00fc";
                q2true = true;
            }
        }

        private void q3answer1_CheckedChanged(object sender, EventArgs e)
        {
            if (q3answer1.Checked)
            {
                label7.ForeColor = Color.Green;
                // This is a tick
                label7.Text = "\u00fc";
                q3true = true;
            }
        }

        private void q3answer2_CheckedChanged(object sender, EventArgs e)
        {
            if (q3answer2.Checked)
            {
                label7.ForeColor = Color.Red;
                // This is a cross
                label7.Text = "\u00fb";
                q3true = false;
            }
        }

        private void q3answer3_CheckedChanged(object sender, EventArgs e)
        {
            if (q3answer3.Checked)
            {
                label7.ForeColor = Color.Red;
                // This is a cross
                label7.Text = "\u00fb";
                q3true = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (q1true && q2true && q3true)
            {
                // Stops the timer if user gets all questions correct
                timer1.Stop();
                MessageBox.Show("You got everything correct!", "Correct");
            }

            else if (timeLeft > 0)
            {
                // Update and displays the remaining time
                timeLeft--;
                timeleftLabel.Text = timeLeft + " seconds";
            }

            else
            {
                timer1.Stop();
                timeleftLabel.Text = "Time's up!";
                MessageBox.Show("No more time remaining!", "Over");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startButton.Enabled = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }
    }
}
