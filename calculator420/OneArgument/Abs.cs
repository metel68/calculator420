using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// This class performs module
    /// </summary>
    public class Abs : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        } 
    }
}