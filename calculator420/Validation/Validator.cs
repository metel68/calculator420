using System;

namespace Calculator.Validation
{
    public class Validator
    {
        public double ValidateNumber(String operand)
        {
            double result;
            if (double.TryParse(operand, out result))
            {
                return result;
            }
            else
            {
                throw new Exception("Input error");
            }
        }

        public double[] ValidateArray(String operand)
        {
            string[] divider = { "," };
            string[] stringArray = operand.Split(divider, StringSplitOptions.RemoveEmptyEntries);
            double[] result = new double[stringArray.Length];
            for (Int16 i = 0; i < stringArray.Length; i++)
            {
                result[i] = ValidateNumber(stringArray[i]);
            }
            return result;
        }
 
    }
}