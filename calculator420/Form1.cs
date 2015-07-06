﻿using System;
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

        private void Compute(object sender, EventArgs e)
        {
            double firstArgument = StrToInt(A.Text);
            double secondArgument = StrToInt(B.Text);
            double result;
                switch (((Button)sender).Name)
                {
                    case "Add":
                        result = firstArgument + secondArgument;
                        break;
                    case "Sub": 
                        result = firstArgument - secondArgument;
                        break;
                    case "Mult": 
                        result = firstArgument * secondArgument;
                        break;
                    case "Div": 
                        result = firstArgument / secondArgument;
                        break;
                    default :
                        throw new Exception("Undefined operation");
                }
                Result.Text = Convert.ToString(result);
        }

    }
}
