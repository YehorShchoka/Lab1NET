using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Principal;
using Lab1;

namespace Lab3_test;

[TestClass]
public class Calculation_abTest
{
    [TestMethod]
    public void Calculation_a_greater_than_b_ThrowsException()
    {
        var calc = new Calculation_ab(2, 1);

        Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.Sun());
    }

    [TestMethod]
    public void Calculation_NoSpecialNumbers_ReturnsZero()
    {

        var calc = new Calculation_ab(1, 20);
        var testRes = 0;

        var res = calc.Sun();

        Assert.AreEqual(testRes, res);
    }

    [TestMethod]
    public void Calculation_OneSpecialNumber_ReturnsThatNumber()
    {

        var calc = new Calculation_ab(20, 25);
        var testRes = 22;

        var res = calc.Sun();

        Assert.AreEqual(testRes, res);
    }

    [TestMethod]
    public void Calculation_MultipleSpecialNumbers_ReturnsProduct()
    {

        var calc = new Calculation_ab(20, 80);
        var testRes = 1694;

        var res = calc.Sun();

        Assert.AreEqual(testRes, res);
    }

    [TestMethod]
    public void Calculation_ThreeSpecialNumbers_ReturnsProduct()
    {

        var calc = new Calculation_ab(20, 150);
        var testRes = 223608;

        var res = calc.Sun();

        Assert.AreEqual(testRes, res);
    }

    [TestMethod]
    public void Calculation_NegativeRange_ReturnsZero()
    {

        var calc = new Calculation_ab(-50, 0);
        var testRes = 0;

        var res = calc.Sun();

        Assert.AreEqual(testRes, res);
    }

    [TestMethod]
    public void Calculation_SingleNumberRange_ReturnsZero()
    {

        var calc = new Calculation_ab(22, 22);
        var testRes = 22;

        var res = calc.Sun(); 

        Assert.AreEqual(testRes, res);
    }
}
