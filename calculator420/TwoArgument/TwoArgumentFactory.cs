using System;

namespace Calculator.TwoArgument
{
    public static class TwoArgmumentFactory
    {
        /// <summary>
        /// Creates and returns an object of selected two-operation calculator
        /// </summary>
        /// <param name="operation">Name of required operation</param>
        /// <returns>Calculator object</returns>
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Add":
                    return new Add();
                case "Sub":
                    return new Sub();
                case "Mult":
                    return new Mult();
                case "Div":
                    return new Div();
                case "Pow":
                    return new Pow();
                case "Root":
                    return new Root();
                default:
                    throw new Exception("Undefined operation");
            }
        }
    }
}