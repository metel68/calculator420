using System;

namespace Calculator.OneArgument
{
    public class Tan : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}