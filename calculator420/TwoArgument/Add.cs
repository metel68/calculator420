namespace Calculator.TwoArgument
{
    /// <summary>
    /// This class performs addition
    /// </summary>
    public class Add : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        } 
    }
}