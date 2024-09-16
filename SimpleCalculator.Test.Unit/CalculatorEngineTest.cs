using System;
using CalculatorEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        CalculatorTools tool = new CalculatorTools();
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {
            
            

            int number1 = 1;
            int number2 = 2;
            double result = tool.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = tool.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = tool.Calculate("subtract", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = tool.Calculate("-", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = tool.Calculate("multiply", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = tool.Calculate("*", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = tool.Calculate("divide", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = tool.Calculate("/", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void ModulusTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 5;
            int number2 = 2;
            double result = tool.Calculate("modulus", number1, number2);
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void ModulusTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 5;
            int number2 = 2;
            double result = tool.Calculate("%", number1, number2);
            Assert.AreEqual(1, result);

        }
    }
}
