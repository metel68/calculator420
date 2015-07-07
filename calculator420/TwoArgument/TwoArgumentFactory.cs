using System;

namespace Calculator.TwoArgument
{
    public static class TwoArgmumentFactory
    {
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