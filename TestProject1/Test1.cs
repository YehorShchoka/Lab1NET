using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1;

namespace Lab3_test
{
    [TestClass]
    public class Calculation_abcTest
    {
        [TestMethod]
        public void Calculation_AllNumbersLessFive_ReturnsSum()
        {

            var calc = new Calculation_abc(1, 2, 3);
            var testRes = 6;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_OneNumberGreaterThanFive_ReturnsCubeOfSum()
        {

            var calc = new Calculation_abc(6, 2, 3);
            var testRes = 1331;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_TwoNumbersGreaterThanFive_ReturnsCubeOfSum()
        {

            var calc = new Calculation_abc(6, 7, 3);
            var testRes = 4096;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_AllNumbersGreaterThanFive_ReturnsCubeOfSum()
        {

            var calc = new Calculation_abc(6, 7, 8);
            var testRes = 9261;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_WithZeroAndFive_ReturnsSum()
        {

            var calc = new Calculation_abc(0, 5, 4);
            var testRes = 9;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_WithNegativeNumbers_ReturnsSum()
        {

            var calc = new Calculation_abc(-2, -1, 3);
            var testRes = 0;

            var res = calc.D();

            Assert.AreEqual(testRes, res);
        }
    }
}
