using System;

namespace Calculator.OneArgument
{  	
    /// <summary>
    /// This class computes tangent
    /// </summary>
    public class Tan : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}