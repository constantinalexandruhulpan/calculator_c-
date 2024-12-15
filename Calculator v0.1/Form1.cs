using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v0._1
{
    public partial class x : Form
    {
        string input = "0";
        string currentValue = "0";
        string newValue = "0";
        char operation;
        double result = 0.0;
        string produs;

        public x()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input += "0";
            this.display.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            this.display.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            this.display.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            this.display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            this.display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            this.display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            this.display.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            this.display.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            this.display.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            this.display.Text += "9";
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            currentValue = input;
            if (currentValue == "0")
                input = "0";
            else
                input += "1";
            operation = '+';
            input = string.Empty;
            display.Text += '+';

        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            currentValue = input;
            operation = '-';
            input = string.Empty;
            display.Text += '-';
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            currentValue = input;
            operation = '*';
            input = string.Empty;
            display.Text += '*';
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            currentValue = input;
            operation = '/';
            input = string.Empty;
            display.Text += '/';
        }

        private void equal_Click(object sender, EventArgs e)
        {
            newValue = input;
            double number1, number2;
            double.TryParse(currentValue, out number1);
            double.TryParse(newValue, out number2);
            switch(operation)
            {
                case '+':
                    result = number1 + number2;
                    display.Text = result.ToString();
                    break;
                case '-':
                    result = number1 - number2;
                    display.Text = result.ToString();
                    break;
                case '*':
                    result = number1 * number2;
                    display.Text = result.ToString();
                    break;
                case '/':
                    if(number2 != 0)
                    {
                        result = number1 / number2;
                        display.Text = result.ToString();
                    }
                    else
                    {
                        display.Text = "Error!";
                    }
                    break;
                case '^':
                    result = 1;
                    for (int i = 1; i <= number2; i++)
                        result *= number1;
                    display.Text = result.ToString();
                    break;
                case 'r':
                    result = Math.Sqrt(number1);
                    display.Text = result.ToString();
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            input = string.Empty;
            currentValue = string.Empty;
            newValue = string.Empty;
            result = 0.0;
        }

        private void power_Click(object sender, EventArgs e)
        {
            currentValue = input;
            operation = '^';
            input = string.Empty;
            display.Text += '^';
        }

        private void sqrtB_Click(object sender, EventArgs e)
        {
            currentValue = input;
            operation = 'r';
            input = string.Empty;
        }
    }
}
