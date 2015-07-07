using System;

namespace Calculator.OneArgument 
{
    public class Sin : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}