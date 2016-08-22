using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstForm
{
    public partial class Birthday : Form
    {
        string name = "";

        public Birthday()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            // Get name form text box
            name = textBoxName.Text;

            // Work how old person is
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker1.Value;

            // Work out age in years.
            int years = ((int)ageDays.TotalDays) / 365;

            // Get date from datetimepicker to display in message
            int day = dateTimePicker1.Value.Day;
            string month = dateTimePicker1.Value.ToString("MMMMM");

            // Creates the message

            message.Text = "Hello, " + name + "! You will be " + (years + 1) 
                + " years old on " + day + " " + month + "."; 
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
