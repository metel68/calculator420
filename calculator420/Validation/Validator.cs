using System;

namespace Calculator.Validation
{
    public class Validator
    {
        /// <summary>
        /// This method validates a text string and converts it to a floating point number
        /// </summary>
        /// <param name="operand">Input string</param>
        /// <returns>Parsed number</returns>
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
        /// <summary>
        /// This method validates a text string and converts it to an array of floating point numbers
        /// </summary>
        /// <param name="operand">Input string</param>
        /// <returns>Array of parsed numbers</returns>
        public double[] ValidateArray(String operand)
        {
            string[] divider = { " " };
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