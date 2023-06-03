
using System;
using MathOperationLibrary;

// Arrange, Act Assert
// expected and actual
// Red, Green, Factor
namespace MathOperationLibrary.Tests
{
	public class MathOperationsTests
	{
		[Fact]
		public void AddShouldReturnFivePointFive()
		{
			// Arrange
			double expected = 5.5;

			// Act
			double actual = MathOperations.Add(1.4, 4.1);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void SubtractShouldReturnNegativeTenPointEight()
		{
			double expected = -10.8;

			double actual = MathOperations.Subtract(24.2, 35);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void MultiplyShouldReturnEightPointFour()
		{
			double expected = 8.4;

			double actual = MathOperations.Multiply(4.2, 2);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void DivideShouldReturnZero()
		{
			double expected = 0;

			double actual = MathOperations.Divide(0, 139.72);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(1.4, 4.1, 5.5)]
		[InlineData(89, 25, 114)]
		[InlineData(-3.6, 72, 68.4)]
		[InlineData(99, -99, 0)]
		public void AddShouldReturnCorrectAnswer(double x, double y, double expected)
		{
			double actual = MathOperations.Add(x, y);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(24.2, 35, -10.8)]
		[InlineData(29, 11, 18)]
		[InlineData(-25.3, -6.9, -18.4)]
		[InlineData(4.7, -72.1, 76.8)]
		public void SubtractShouldReturnCorrectAnswer(double x, double y, double expected)
		{
			double actual = MathOperations.Subtract(x, y);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(2, 3, 6)]
		[InlineData(5.3, 19, 100.7)]
		[InlineData(17.8, -13, -231.4)]
		[InlineData(-0.25, -40, 10)]
		[InlineData(0, -123.6783234923, 0)]
		public void MultiplyShouldReturnCorrectAnswer(double x, double y, double expected)
		{
			double actual = MathOperations.Multiply(x, y);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(100, 4, 25)]
		[InlineData(36.5, 5, 7.3)]
		[InlineData(-48.8, 4, -12.2)]
		[InlineData(-9.6, -8, 1.2)]
		[InlineData(0, -22345.46343, 0)]
		[InlineData(-4323421.7645, 0, 0)]  // My code return 0 if trying to divide by 0
		public void DivideShouldReturnCorrectAnswer(double x, double y, double expected)
		{
			double actual = MathOperations.Divide(x, y);

			Assert.Equal(expected, actual);
		}
	}
}

