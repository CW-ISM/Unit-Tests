using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests;

[TestClass()]
public class SimpleMathTests
{
    [TestMethod()]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
    {
        // Use the DataRow values to test the Add method
        Assert.IsTrue(SimpleMath.Add(num1, num2) == num1 + num2);
    }

    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
    {
        // Use a few pairs of values to test the Multiply method
        Assert.IsTrue(SimpleMath.Multiply(num1, num2) == num1 * num2);
    }

    [TestMethod]
    [DataRow(10)]
    [DataRow(100)]
    [DataRow(-10)]
    public void Divide_DenominatorZero_ThrowsArgumentException(double num1)
    {
        // Divide by zero should throw an argument exception with a message
        // "Denominator cannot be zero"
        Assert.ThrowsExactly<DivideByZeroException>(() => SimpleMath.Divide(num1, 0), "Cannot divide by zero");
    }

    // TODO: Add a new test to test the Divide method with two valid numbers
    [TestMethod]
    [DataRow(10, 2)]
    [DataRow(100, 10)]
    [DataRow(-10, -2)]
    public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
    {
        Assert.IsTrue(SimpleMath.Divide(num1, num2) == num1 / num2);
    }

    // TODO: Add a new test to test the subtract method with two valid numbers
    [TestMethod]
    [DataRow(10, 5)]
    [DataRow(100, 50)]
    [DataRow(-10, -5)]
    public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
    {
        Assert.IsTrue(SimpleMath.Subtract(num1, num2) == num1 - num2);
    }
}