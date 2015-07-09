using System;

namespace Calculator.OneArgument

{
    public class Arcsin : IOperation
    {
        public double Calculate(double argument)
        {
            if ((argument < -1) && (argument > 1))
            {
                throw new Exception("Argument not in range");
            }
            else
            {
                return Math.Asin(argument);
            }
        }
    }
}