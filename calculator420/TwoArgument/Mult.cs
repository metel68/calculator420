namespace Calculator.TwoArgument
{
    /// <summary>
    /// This class performs multiplication
    /// </summary>
    public class Mult : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        } 
    }
}