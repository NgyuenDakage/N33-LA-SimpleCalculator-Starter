using System;

namespace CalculatorEngine
{
    public class CalculatorTools
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add") {
                result = argFirstNumber + argSecondNumber;
            }
            if (argOperation == "-" || argOperation.ToLower() == "subtract")
            {
                result = argFirstNumber - argSecondNumber;
            }
            if (argOperation == "*" || argOperation.ToLower() == "multiply")
            {
                result = argFirstNumber * argSecondNumber;
            }
            if (argOperation == "/" || argOperation.ToLower() == "divide")
            {
                result = argFirstNumber / argSecondNumber;
            }
            if (argOperation == "%" || argOperation.ToLower() == "modulus")
            {
                result = argFirstNumber % argSecondNumber;
            }

            return result;
        }
    }
}
