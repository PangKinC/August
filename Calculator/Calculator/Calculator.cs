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

        decimal opOne;
        decimal opTwo;

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

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operandTwo = resultBox.Text;

            decimal.TryParse(operandOne, out opOne);
            decimal.TryParse(operandTwo, out opTwo);

            switch (operation)
            {
                case '+':
                    result = (opOne + opTwo).ToString();
                    break;
                case '-':
                    result = (opOne - opTwo).ToString();
                    break;
                case '*':
                    result = (opOne * opTwo).ToString();
                    break;
                case '/':
                    if (opTwo != 0) { result = (opOne / opTwo).ToString(); }
                    else { result = "Can't divide by 0."; }
                    break;
            }
            resultBox.Text = result;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operandOne = resultBox.Text;
            operation = '+';
            resultBox.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operandOne = resultBox.Text;
            operation = '-';
            resultBox.Text = "";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            operandOne = resultBox.Text;
            operation = '*';
            resultBox.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operandOne = resultBox.Text;
            operation = '/';
            resultBox.Text = "";
        }

        private void resultBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1) { buttonOne.PerformClick(); }
            if (e.KeyCode == Keys.NumPad2) { buttonTwo.PerformClick(); }
            if (e.KeyCode == Keys.NumPad3) { buttonThree.PerformClick(); }
            if (e.KeyCode == Keys.NumPad4) { buttonFour.PerformClick(); }
            if (e.KeyCode == Keys.NumPad5) { buttonFive.PerformClick(); }
            if (e.KeyCode == Keys.NumPad6) { buttonSix.PerformClick(); }
            if (e.KeyCode == Keys.NumPad7) { buttonSeven.PerformClick(); }
            if (e.KeyCode == Keys.NumPad8) { buttonEight.PerformClick(); }
            if (e.KeyCode == Keys.NumPad9) { buttonNine.PerformClick(); }
            if (e.KeyCode == Keys.NumPad0) { buttonZero.PerformClick(); }
            if (e.KeyCode == Keys.Decimal) { buttonDot.PerformClick(); }

            if (e.KeyCode == Keys.Add) { buttonPlus.PerformClick(); }
            if (e.KeyCode == Keys.Subtract) { buttonMinus.PerformClick(); }
            if (e.KeyCode == Keys.Multiply) { buttonTimes.PerformClick(); }
            if (e.KeyCode == Keys.Divide) { buttonDivide.PerformClick(); }
            if (e.KeyCode == Keys.Enter) { buttonEquals.PerformClick(); }
            if (e.KeyCode == Keys.Escape) { buttonClear.PerformClick(); }

            else { e.SuppressKeyPress = true; }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            operandOne = "";
            operandTwo = "";
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(resultBox.Text, out opOne)) { resultBox.Text = (Math.Sqrt((double)opOne)).ToString(); }   
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(resultBox.Text, out opOne)) { resultBox.Text = (opOne * opOne).ToString(); }
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(resultBox.Text, out opOne)) { resultBox.Text = decimal.Negate(opOne).ToString(); }
        }
    }
}
