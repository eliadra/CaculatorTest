using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void PlussTest1()
        {
            int result = Calculator.Pluss(1025,3);
            Assert.AreEqual(1028,result);
        }
        public void PlussTest2()
        {
            int result = Calculator.Pluss(-2,10);
            Assert.AreEqual(8, result);
        }
        public void PlussTest3()
        {
            int result = Calculator.Pluss(0, 50);
            Assert.AreEqual(50, result);
        }
        public void PlussTest4()
        {
            int result = Calculator.Pluss(0, -100);
            Assert.AreEqual(-100, result);
        }
        public void PlussTest5()
        {
            double result = Calculator.PlussDouble(2.8, 3.2);
            Assert.AreEqual(6, result);
        }

        public void MinusTest1()
        {
            double result = Calculator.MinusDouble(2.8, 3.2);
            Assert.AreEqual(0.4, result);
        }
        public void MinusTest2()
        {
            int result = Calculator.Minus(0, -100);
            Assert.AreEqual(100, result);
        }
        public void MinusTest3()
        {
            int result = Calculator.Minus(0, 50);
            Assert.AreEqual(-50, result);
        }
        public void MinusTest4()
        {
            int result = Calculator.Minus(-2, 10);
            Assert.AreEqual(-12, result);
        }
        public void MinusTest5()
        {
            int result = Calculator.Minus(1025, 3);
            Assert.AreEqual(1022, result);

        }

        public void MultiplicationTest1()
        {
            double result = Calculator.MultiplicationDouble(2.8, 3.2);
            Assert.AreEqual(8.96, result);
        }
        public void MultiplicationTest2()
        {
            int result = Calculator.Multiplication(0, -100);
            Assert.AreEqual(0, result);
        }
        public void MultiplicationTest3()
        {
            int result = Calculator.Multiplication(0, 50);
            Assert.AreEqual(0, result);
        }
        public void MultiplicationTest4()
        {
            int result = Calculator.Multiplication(-2, 10);
            Assert.AreEqual(-20, result);
        }
        public void MultiplicationTest5()
        {
            int result = Calculator.Multiplication(1025, 3);
            Assert.AreEqual(3075, result);

        }

        public void DivisionTest1()
        {
            double result = Calculator.DivisionDouble(2.8, 3.2);
            Assert.AreEqual(0.875, result);
        }
        public void DivisionTest2()
        {
            int result = Calculator.Division(0, -100);
            Assert.AreEqual(0, result);
        }
        public void DivisionTest3()
        {
            int result = Calculator.Division(50, 0);
            Assert.AreEqual(0, result);
        }
        public void DivisionTest4()
        {
            int result = Calculator.Division(-2, 10);
            Assert.AreEqual(-0.2, result);
        }
        public void DivisionTest5()
        {
            int result = Calculator.Division(1025, 5);
            Assert.AreEqual(205, result);

        }
    }
}
