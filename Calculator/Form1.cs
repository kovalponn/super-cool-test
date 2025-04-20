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
    public partial class Form1 : Form
    {

        public double number_one;
        public double number_two;
        public string sing;
        public double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            Calculate.Text += 1; 
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Calculate.Text += 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Calculate.Text += 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Calculate.Text += 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Calculate.Text += 5;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Calculate.Text += 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Calculate.Text += 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Calculate.Text += 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Calculate.Text += 9;
        }

        private void Null_Click(object sender, EventArgs e)
        {
            Calculate.Text += 0;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            number_one = Convert.ToDouble(Calculate.Text);
            Calculate.Text = null;
            sing = "+";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            number_one = Convert.ToDouble(Calculate.Text);
            Calculate.Text = null;
            sing = "-";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            number_one = Convert.ToDouble(Calculate.Text);
            Calculate.Text = null;
            sing = "/";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            number_one = Convert.ToDouble(Calculate.Text);
            Calculate.Text = null;
            sing = "*";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            
            number_two = Convert.ToDouble(Calculate.Text);

         if (number_two == 0f)
            {
                Calculate.Text = "Error";
            }
         else
            {
            if (sing == "+")
            {
                result = number_one + number_two;
            }
            else if (sing == "-")
            {
                result = number_one - number_two;
            }
            else if (sing == "/")
            {
                result = number_one / number_two;
            }
            else
            {
                result = number_one * number_two;   
            }

            Calculate.Text = result.ToString();
            }

        }
    }
}
