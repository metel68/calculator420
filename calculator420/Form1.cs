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
        static Int16 i=0;
        private void SendUser(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    Result.Text = "Чего-нить";
                    break;
                case 2:
                    Result.Text = "А я знаю, чего вам надо?";
                    break;
                case 3:
                    Result.Text = "Определитесь уже?";
                    break;
                case 4:
                    Result.Text = "42";
                    break;
                case 5:
                    Result.Text = "42, я сказал!";
                    break;
                case 6:
                    Result.Text = "А не знаю, просто 42 и всё";
                    break;
                case 10:
                    Result.Text = "Задолбали";
                    break;
                case 11:
                    throw new Exception("Пользователь задолбал программу");
            }
        }

    }
}
