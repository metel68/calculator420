using System;

namespace Calculator.OneArgument 
{
    /// <summary>
    /// This class computes sinus
    /// </summary>
    public class Sin : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}