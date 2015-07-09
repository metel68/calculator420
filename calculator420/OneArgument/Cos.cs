using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// This class computes cosine
    /// </summary>
    public class Cos : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}