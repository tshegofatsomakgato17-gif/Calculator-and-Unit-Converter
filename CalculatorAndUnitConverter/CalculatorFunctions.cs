
namespace CalculatorAndUnitConverter
{
    public static class CalculatorFunctions
    {
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return firstNumber / secondNumber;
        }

        public static double KilometresToMiles(double kilometres)
        {
            return kilometres * 0.621371;
        }

        public static double MilesToKilometres(double miles)
        {
            return miles * 1.609344;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double GhanaCedisToUsd(double cedis, double cedisPerDollar)
        {
            if (cedisPerDollar <= 0)
            {
                throw new ArgumentException("Exchange rate must be greater than zero.");
            }

            return cedis / cedisPerDollar;
        }
    }
}
