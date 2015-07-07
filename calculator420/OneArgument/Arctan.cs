using System;

namespace Calculator.OneArgument
{
    public class Arctan : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}