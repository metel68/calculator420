using System;

namespace Calculator.OneArgument
{
    public class Arccos : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Acos(argument);
        }
    }
}