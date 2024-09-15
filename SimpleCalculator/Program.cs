using CalculatorEngine;
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0;
            Boolean checkInput = true;
            while (checkInput)
            {
                Console.WriteLine("Input first number: ");
                string input1 = Console.ReadLine();
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
                string input2 = Console.ReadLine();
                if (double.TryParse(input2, out double r))
                {
                    secondNumber = InputConverter.ConvertInputToNumeric(input2);
                    checkSecondInput = false;
                }
                else
                {
                    System.Console.WriteLine("Conversion error: please enter a valid number");
                }
            }

            string[] operations = new string[]{"add", "subtract", "multiply", "divide", "+", "-", "*", "/"};
            Boolean checkOperation = true;
            string operation = null;
            while (checkOperation)
            {
                Console.WriteLine("Input the operation: ");
                operation = Console.ReadLine();
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operation == operations[i])
                    {
                        checkOperation = false;
                    }
                }
                
            }

            CalculatorTools tool = new CalculatorTools();

            double result = tool.Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine($"The result of the {operation} operation with numbers {firstNumber} and {secondNumber} is {result:F2}");
        }
    }
}
