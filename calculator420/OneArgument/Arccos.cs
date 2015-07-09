using System;

namespace Calculator.OneArgument
{
    public class Arccos : IOperation
    {
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Arccos from negative number");
            }
            else
            {
                return Math.Acos(argument);
            }
        }
    }
}