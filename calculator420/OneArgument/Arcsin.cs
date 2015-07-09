using System;

namespace Calculator.OneArgument

{
    public class Arcsin : IOperation
    {
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Arcsin from negative number");
            }
            else
            {
                return Math.Asin(argument);
            }
        }
    }
}