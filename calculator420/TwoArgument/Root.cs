using System;

namespace Calculator.TwoArgument
{
    public class Root : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1/secondArgument);
        }
    }
}