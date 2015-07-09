using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// This class computes arctangent
    /// </summary>
    public class Arctan : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}