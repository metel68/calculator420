using System;

namespace Calculator.TwoArgument
{
    public class Root : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Division by zero");
            }
            else
            {
                if ((firstArgument < 0) && (secondArgument%2 == 0))
                {
                    throw new Exception("Even root from negatiwe number");
                }
                else
                {
                    return Math.Pow(firstArgument, 1/secondArgument);
                }
            }
        }
    }
}