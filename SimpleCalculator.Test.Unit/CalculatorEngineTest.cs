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
    }
}
