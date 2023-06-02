
using System;
using Xunit;

// Arrange, Act, Assert
// expected and actual
// Red, Green, Refactor
namespace DemoLibrary.Tests
{
	public class DisplayMessagesTests
	{
		[Fact]
		public void GreetingShouldReturnGoodMorningMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good morning Kim";

			// Act
			string actual = messages.Greeting("Kim", 2);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void GreetingShouldReturnGoodAfternoonMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good afternoon Kim";

			// Act
			string actual = messages.Greeting("Kim", 14);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("Kim", 0, "Good morning Kim")]
        [InlineData("Kim", 1, "Good morning Kim")]
        [InlineData("Kim", 2, "Good morning Kim")]
        [InlineData("Kim", 3, "Good morning Kim")]
        [InlineData("Kim", 4, "Good morning Kim")]
        [InlineData("Kim", 5, "Good morning Kim")]
        [InlineData("Kim", 6, "Good morning Kim")]
        [InlineData("Kim", 7, "Good morning Kim")]
        [InlineData("Kim", 8, "Good morning Kim")]
        [InlineData("Kim", 9, "Good morning Kim")]
        [InlineData("Kim", 10, "Good morning Kim")]
        [InlineData("Kim", 11, "Good morning Kim")]
        [InlineData("Kim", 12, "Good afternoon Kim")]
        [InlineData("Kim", 13, "Good afternoon Kim")]
        [InlineData("Kim", 14, "Good afternoon Kim")]
        [InlineData("Kim", 15, "Good afternoon Kim")]
        [InlineData("Kim", 16, "Good afternoon Kim")]
        [InlineData("Kim", 17, "Good afternoon Kim")]
        [InlineData("Kim", 18, "Good evening Kim")]
        [InlineData("Kim", 19, "Good evening Kim")]
        [InlineData("Kim", 20, "Good evening Kim")]
        [InlineData("Kim", 21, "Good evening Kim")]
        [InlineData("Kim", 22, "Good evening Kim")]
        [InlineData("Kim", 23, "Good evening Kim")]
        public void GreetingShouldReturnExpectedValue(
			string firstName,
			int hourOfTheDay,
			string expected)
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();

			// Act
			string actual = messages.Greeting(firstName, hourOfTheDay);

			// Assert
			Assert.Equal(expected, actual);
		}
    }
}

