using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// This class performs extraction root
    /// </summary>
    public class Sqrt : IOperation
    {
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("sqrt from negative number");
            }
            else
            {
                return Math.Sqrt(argument);
            }
        }
    }
}