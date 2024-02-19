using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // TODO: Write your test here...
        Calculate calculate=new Calculate();
        int actualresult = calculate.Subtraction(5, 2);

        Assert.That(3 == actualresult);
    }
}
