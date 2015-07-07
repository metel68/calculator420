using System;

namespace Calculator.OneArgument

{
    public class Arcsin : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Asin(argument);
        }
    }
}