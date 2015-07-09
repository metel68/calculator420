using System;
using System.Resources;
using System.Windows.Forms;
using Calculator.ArraySort;
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

        private void SortArray(object sender, EventArgs e)
        {
            string[] divider = {","};
            string[] stringArray = FirstValue.Text.Split(divider, StringSplitOptions.RemoveEmptyEntries);
            double[] argument = new double[stringArray.Length];
            for (Int16 i = 0; i < stringArray.Length; i++)
            {
                argument[i] = StrToInt(stringArray[i]);
            }
            string operation = ((Button)sender).Name;
            var op = ArraySortFactory.CreateCalculator(operation);
            op.Calculate(argument);
            Result.Text = "";
            for (Int16 i = 0; i < argument.Length; i++)
            {
                Result.Text += Convert.ToString(argument[i]);
                Result.Text += ", ";
            }
        }
        static Int16 i=0;
        private void SendUser(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    Result.Text = "Something";
                    break;
                case 2:
                    Result.Text = "What the fuck you want?";
                    break;
                case 3:
                    Result.Text = "42";
                    break;
                case 4:
                    Result.Text = "42, I said!";
                    break;
                case 5:
                    Result.Text = "А не знаю, просто 42 и всё";
                    break;
                case 6:
                    Result.Text = "Что-то не так?";
                    break;
                case 7:
                    Result.Text = "Задолбали со своим Engrish'ем";
                    break;
                case 8:
                    throw new Exception("Пользователь задолбал программу");
            }
        }

    }
}
