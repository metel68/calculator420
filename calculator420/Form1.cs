using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private double StrToInt(String operand)
        {
            double result;
            if (double.TryParse(operand, out result))
            {
                return result;
            }
            else
            {
                throw new Exception("Input error");
            }
        }

        private String Compute(double firstArgument, double secondArgument, char operation)
        {
            double result;
                switch (operation)
                {
                    case '+':
                        result = firstArgument + secondArgument;
                        break;
                    case '-': 
                        result = firstArgument - secondArgument;
                        break;
                    case '*': 
                        result = firstArgument * secondArgument;
                        break;
                    case '/': 
                        result = firstArgument / secondArgument;
                        break;
                    default :
                        throw new Exception("Undefined operation");
                }
                return Convert.ToString(result);
        }

        private void AddClick(object sender, EventArgs e)
        {
            Result.Text = Compute(StrToInt(A.Text), StrToInt(B.Text), '+');
        }

        private void SubClick(object sender, EventArgs e)
        {
            Result.Text = Compute(StrToInt(A.Text), StrToInt(B.Text), '-');
        }

        private void MultClick(object sender, EventArgs e)
        {
            Result.Text = Compute(StrToInt(A.Text), StrToInt(B.Text), '*');
        }

        private void DivClick(object sender, EventArgs e)
        {
            Result.Text = Compute(StrToInt(A.Text), StrToInt(B.Text), '/');
        }
    }
}
