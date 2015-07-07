using System;

namespace Calculator.OneArgument
{
    public class Cos : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}