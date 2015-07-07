namespace Calculator.TwoArgument
{
    public class Add : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        } 
    }
}