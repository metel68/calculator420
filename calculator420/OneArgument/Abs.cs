using System;

namespace Calculator.OneArgument
{
    public class Abs : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        } 
    }
}