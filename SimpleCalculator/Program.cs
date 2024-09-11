    using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstNumber = 0;
            Boolean checkInput = true;
            while (checkInput)
            {
                Console.WriteLine("Input first number: ");
                String input1 = Console.ReadLine();
                if (double.TryParse(input1, out double r))
                {
                    firstNumber = InputConverter.ConvertInputToNumeric(input1);
                    checkInput = false;
                }
                else
                {
                    System.Console.WriteLine("Conversion error: please enter a valid number");
                }
            }

            double secondNumber = 0;
            Boolean checkSecondInput = true;
            while (checkSecondInput)
            {
                Console.WriteLine("Input second number: ");
                String input2 = Console.ReadLine();
                if (double.TryParse(input2, out double r))
                {
                    secondNumber = InputConverter.ConvertInputToNumeric(input2);
                    checkInput = false;
                }
                else
                {
                    System.Console.WriteLine("Conversion error: please enter a valid number");
                }
            }


            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine("The value " + firstNumber + " plus the value " + secondNumber + " is equal to " + result);
        }
    }
}
