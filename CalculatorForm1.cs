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


    public partial class CalculatorForm1 : Form
    {

        string input = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        char operation;
        double answer = 0.0;
        int numCount = 0;

        public CalculatorForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            input += 1;
            showInput();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            input += 2;
            showInput();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            input += 3;
            showInput();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            input += 4;
            showInput();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            input += 5;
            showInput();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += 6;
            showInput();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += 7;
            showInput();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += 8;
            showInput();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += 9;
            showInput();

        }

        private void button0_Click(object sender, EventArgs e)
        {
            input += 0;
            showInput();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            numCount++;
            if(numCount >= 2)
            {
                buttonEq_Click_1(sender, e);
            }
            num1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            numCount++;
            if (numCount >= 2)
            {
                buttonEq_Click_1(sender, e);
            }
            num1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonX_Click_1(object sender, EventArgs e)
        {
            numCount++;
            if (numCount >= 2)
            {
                buttonEq_Click_1(sender, e);
            }
            num1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonDiv_Click_1(object sender, EventArgs e)
        {
            numCount++;
            if (numCount >= 2)
            {
                buttonEq_Click_1(sender, e);
            }
            num1 = input;
            operation = '/';
            input = string.Empty;
        }



        private void showInput()
        {
            Display.Text = "";
            Display.Text = input;
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEq_Click_1(object sender, EventArgs e)
        {

            num2 = input;
            double first, second;
            double.TryParse(num1, out first);
            double.TryParse(num2, out second);

            if(numCount > 2)
            {
                first = answer;
            }

            if (operation == '+')
            {
                answer = first + second;
                Display.Text = answer.ToString();
            }
            else if (operation == '-')
            {
                answer = first - second;
                Display.Text = answer.ToString();
            }
            else if (operation == '*')
            {
                if (second == 0)
                {
                    answer = first;
                }
                 if (first == 0)
                {
                    answer = second;
                }
                if (first != 0 && second != 0)
                {
                    answer = first * second;
                }
                    Display.Text = answer.ToString();
            }
            else if (operation == '/')
            {
                if (second != 0)
                {
                    answer = first / second;
                    Display.Text = answer.ToString();
                }
                else
                {
                    Display.Text = "Error!";
                }

            }
            operation = 'N';
            numCount++;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            input = string.Empty;
            num1 = string.Empty;
            num2 = string.Empty;
            operation = 'N';
            numCount = 0;

        }
    }
}
