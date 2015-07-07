namespace Calculator.TwoArgument
{
    public class Div : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}