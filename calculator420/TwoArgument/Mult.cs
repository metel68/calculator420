namespace Calculator.TwoArgument
{
    public class Mult : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        } 
    }
}