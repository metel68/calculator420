using System;

namespace Calculator.TwoArgument
{
    /// <summary>
    /// This class performs power
    /// </summary>
    public class Pow : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument,secondArgument);
        }
    }
}