namespace Calculator.TwoArgument
{
    public class Sub : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        } 
    }
}