namespace Calculator.TwoArgument
{
    /// <summary>
    /// This class performs subtraction
    /// </summary>
    public class Sub : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        } 
    }
}