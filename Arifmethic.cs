using System;

public class Arifmethic
{
	public Arifmethic()
	{
	}

    public String Compute(String A, String B, char op)
    {
         double firstArgument, secondArgument;
        if (double.TryParse(A, out firstArgument) &&
            double.TryParse(B, out secondArgument))
        {
            switch (op)
            {
                case '+': return Convert.ToString(firstArgument + secondArgument);
                case '-': return Convert.ToString(firstArgument - secondArgument);
                case '*': return Convert.ToString(firstArgument * secondArgument);
                case '/': return Convert.ToString(firstArgument / secondArgument);

            }
        }
        else
        {
            return "Error";
        }
    }

}
