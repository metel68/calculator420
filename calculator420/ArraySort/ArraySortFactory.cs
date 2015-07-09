using System;
using System.Diagnostics;

namespace Calculator.ArraySort
{
    public class ArraySortFactory
    {
        /// <summary>
        /// Creates and returns an object of selected sorter
        /// </summary>
        /// <param name="operation">Array sorting method</param>
        /// <returns></returns>
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