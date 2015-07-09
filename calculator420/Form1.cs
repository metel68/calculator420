using System;
using System.Windows.Forms;
using Calculator.ArraySort;
using Calculator.OneArgument;
using Calculator.TwoArgument;
using Calculator.Validation;


namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      /// <summary>
      /// Event and exception handler for one-operand functoins
      /// </summary>
      /// <param name="sender">Pressed button name</param>
        private void ComputeOne(object sender, EventArgs e)
        {
          try
          {
              var validator = new Validator();
              double argument = validator.ValidateNumber(FirstValue.Text);
              string operation = ((Button)sender).Name;
              var op = OneArgmumentFactory.CreateCalculator(operation);
              double result = op.Calculate(argument);
              Result.Text = Convert.ToString(result);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "You are a clayfish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }

        /// <summary>
        /// Event and exception handler for two-operand functoins
        /// </summary>
        /// <param name="sender">Pressed button name</param>
        private void ComputeTwo(object sender, EventArgs e)
        {
            try
            {
                var validator = new Validator();
                double firstArgument = validator.ValidateNumber(FirstValue.Text);
                double secondArgument = validator.ValidateNumber(SecondValue.Text);
                string operation = ((Button) sender).Name;
                var op = TwoArgmumentFactory.CreateCalculator(operation);
                double result = op.Calculate(firstArgument, secondArgument);
                Result.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "You are a clayfish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Event and exception handler for array sorting functoins
        /// </summary>
        /// <param name="sender">Pressed button name</param>
        private void SortArray(object sender, EventArgs e)
        {
            try
            {
                if (FirstValue.Text.Equals(""))
                {
                    throw new Exception("Input field is empty");
                }
                var validator = new Validator();
                double[] argument = validator.ValidateArray(FirstValue.Text);
                string operation = ((Button) sender).Name;
                var op = ArraySortFactory.CreateCalculator(operation);
                op.Calculate(argument);
                Result.Text = "";
                for (Int16 i = 0; i < argument.Length; i++)
                {
                    Result.Text += Convert.ToString(argument[i]);
                    Result.Text += ", ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "You are a clayfish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //:trollface:
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
