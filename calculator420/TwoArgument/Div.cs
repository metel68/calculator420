using System;

namespace Calculator.TwoArgument
{
    public class Div : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Division by zero");
            }
            else
            {
                return firstArgument / secondArgument;
            }
        }
    }
}