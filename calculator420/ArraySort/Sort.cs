using System;

namespace Calculator.ArraySort
{
    public class SortArray : IOperation
    {
        private string _method;
        public SortArray(string method)
        {
            this._method = method;
        }

        public void Calculate(double[] array)
        {
            switch (this._method)
            {
                case "slow":
                    for (int i = 0; i < array.Length - 1; i++)
                        for (int j = 0; j < array.Length - i - 1; j++)
                            if (array[j] > array[j + 1])
                            {
                                double tmp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = tmp;
                            }
                    break;
                case "fast":
                    Array.Sort(array);
                    break;
            }
        }
    }
}