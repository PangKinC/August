using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string operandOne = "";
        string operandTwo = "";
        string result;
        char operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            buttonOne.Click += new EventHandler(numberClick);
            buttonTwo.Click += new EventHandler(numberClick);
            buttonThree.Click += new EventHandler(numberClick);
            buttonFour.Click += new EventHandler(numberClick);
            buttonFive.Click += new EventHandler(numberClick);
            buttonSix.Click += new EventHandler(numberClick);
            buttonSeven.Click += new EventHandler(numberClick);
            buttonEight.Click += new EventHandler(numberClick);
            buttonNine.Click += new EventHandler(numberClick);
            buttonZero.Click += new EventHandler(numberClick);
            buttonDot.Click += new EventHandler(numberClick);

        }

        public void numberClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            switch (b.Name)
            {
                case "buttonOne":
                    resultBox.Text += "1";
                    break;
                case "buttonTwo":
                    resultBox.Text += "2";
                    break;
                case "buttonThree":
                    resultBox.Text += "3";
                    break;
                case "buttonFour":
                    resultBox.Text += "4";
                    break;
                case "buttonFive":
                    resultBox.Text += "5";
                    break;
                case "buttonSix":
                    resultBox.Text += "6";
                    break;
                case "buttonSeven":
                    resultBox.Text += "7";
                    break;
                case "buttonEight":
                    resultBox.Text += "8";
                    break;
                case "buttonNine":
                    resultBox.Text += "9";
                    break;
                case "buttonZero":
                    resultBox.Text += "0";
                    break;
                case "buttonDot":
                    if (!resultBox.Text.Contains(".")) { resultBox.Text += "."; }
                    break;
                default:
                    break;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operandOne = resultBox.Text;
            operation = '+';
            resultBox.Text = "";
        }

        private void resultBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    break;
                default:
                    break;

            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operandTwo = resultBox.Text;

            double opOne;
            double opTwo;

            double.TryParse(operandOne, out opOne);
            double.TryParse(operandTwo, out opTwo);


            switch (operation)
            {
                case '+':
                    result = (opOne + opTwo).ToString();
                    break;

            }

            resultBox.Text = result;

        }
    }
}
