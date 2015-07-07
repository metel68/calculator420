using System;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArgument;

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


        private void ComputeOne(object sender, EventArgs e)
        {
            double argument = StrToInt(FirstValue.Text);
            string operation = ((Button) sender).Name;
            var op = OneArgmumentFactory.CreateCalculator(operation);
            double result = op.Calculate(argument);
            Result.Text = Convert.ToString(result);
        }

        private void ComputeTwo(object sender, EventArgs e)
        {
            double firstArgument = StrToInt(FirstValue.Text);
            double secondArgument = StrToInt(SecondValue.Text);
            string operation = ((Button) sender).Name;
            var op = TwoArgmumentFactory.CreateCalculator(operation);
            double result = op.Calculate(firstArgument, secondArgument);
            Result.Text = Convert.ToString(result);
        }

    }
}
