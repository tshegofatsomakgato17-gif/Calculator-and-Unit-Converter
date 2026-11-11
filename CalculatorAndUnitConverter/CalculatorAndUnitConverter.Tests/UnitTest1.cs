using System;
using CalculatorAndUnitConverter;
using Xunit;

namespace CalculatorAndUnitConverter.Tests
{
    public class CalculatorFunctionsTests
    {
        [Theory]
        [InlineData(10, 5, 15)]
        [InlineData(-3, 2, -1)]
        public void Add_ReturnsCorrectSum(double a, double b, double expected)
        {
            Assert.Equal(expected, CalculatorFunctions.Add(a, b), 5);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.Equal(5, CalculatorFunctions.Subtract(10, 5), 5);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            Assert.Equal(50, CalculatorFunctions.Multiply(10, 5), 5);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            Assert.Equal(2, CalculatorFunctions.Divide(10, 5), 5);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(
                () => CalculatorFunctions.Divide(10, 0));
        }

        [Fact]
        public void KilometresToMiles_ReturnsCorrectConversion()
        {
            Assert.Equal(6.21371, CalculatorFunctions.KilometresToMiles(10), 5);
        }

        [Fact]
        public void MilesToKilometres_ReturnsCorrectConversion()
        {
            Assert.Equal(16.09344, CalculatorFunctions.MilesToKilometres(10), 5);
        }

        [Fact]
        public void CelsiusToFahrenheit_ReturnsCorrectConversion()
        {
            Assert.Equal(32, CalculatorFunctions.CelsiusToFahrenheit(0), 5);
        }

        [Fact]
        public void FahrenheitToCelsius_ReturnsCorrectConversion()
        {
            Assert.Equal(0, CalculatorFunctions.FahrenheitToCelsius(32), 5);
        }

        [Fact]
        public void GhanaCedisToUsd_ReturnsCorrectConversion()
        {
            Assert.Equal(10, CalculatorFunctions.GhanaCedisToUsd(100, 10), 5);
        }

        [Fact]
        public void GhanaCedisToUsd_InvalidRate_ThrowsException()
        {
            Assert.Throws<ArgumentException>(
                () => CalculatorFunctions.GhanaCedisToUsd(100, 0));
        }
    }
}