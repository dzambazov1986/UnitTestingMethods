using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string emptyString= string.Empty;

        // Act
        //StringReverse.Reverse(input);
        string actualResult = StringReverse.Reverse(emptyString);

        // Assert
        //Assert.AreEqual();
        Assert.AreEqual(string.Empty, actualResult);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string letter = "s";

        string actualResult = StringReverse.Reverse(letter);

        Assert.AreEqual(letter, actualResult);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string text = "mitko";

            string actulalResult = StringReverse.Reverse(text);
        string expectedResult = "oktim";
        Assert.AreEqual(expectedResult, actulalResult);
    }
}
