using System;
using System.Diagnostics;

namespace Calculator.ArraySort
{
    public class ArraySortFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "FastSort": 
                    return new SortArray("fast");
                case "SlowSort": 
                    return new SortArray("slow");
                default:
                    throw new Exception("Undefined operation");
            }
        }
    }
}