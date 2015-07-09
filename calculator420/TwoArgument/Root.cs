using System;

namespace Calculator.TwoArgument
{
    /// <summary>
    /// This class performs extraction root for any reason
    /// </summary>
    public class Root : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Division by zero");
            }
            if ((firstArgument < 0) && (secondArgument%2 == 0))
            {
                throw new Exception("Even root from negatiwe number");
            }

            return Math.Pow(firstArgument, 1/secondArgument);
        }
    }
}