using System;

namespace Calculator.TwoArgument
{
    public class Pow : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument,secondArgument);
        }
    }
}