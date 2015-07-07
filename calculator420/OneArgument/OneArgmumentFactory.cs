using System;

namespace Calculator.OneArgument
{
    public static class OneArgmumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Abs":
                    return new Abs();
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tan":
                    return new Tan();
                case "Arcsin":
                    return new Arcsin();
                case "Arccos":
                    return new Arccos();
                case "Arctan":
                    return new Arctan();
                case "Sqrt":
                    return new Sqrt();
                default:
                    throw new Exception("Undefined operation");
            }
        }
    }
}