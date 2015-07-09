using System;

namespace Calculator.OneArgument
{
    public class Arccos : IOperation
    {
        public double Calculate(double argument)
        {
            if ((argument < -1) && (argument > 1))
            {
                throw new Exception("Arccos lalala");
            }
            else
            {
                return Math.Acos(argument);
            }
        }
    }
}