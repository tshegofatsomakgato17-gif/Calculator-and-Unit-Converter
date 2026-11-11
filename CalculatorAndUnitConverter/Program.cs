
using System;

namespace CalculatorAndUnitConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("====================================");
            Console.WriteLine("   CALCULATOR AND UNIT CONVERTER");
            Console.WriteLine("====================================");

            while (running)
            {
                Console.WriteLine("\nMAIN MENU");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Distance Converter");
                Console.WriteLine("3. Temperature Converter");
                Console.WriteLine("4. Currency Converter");
                Console.WriteLine("5. Exit");

                int choice = InputHelper.ReadMenuChoice(
                    "\nEnter your choice: ");

                switch (choice)
                {
                    case 1:
                        RunCalculator();
                        break;

                    case 2:
                        RunDistanceConverter();
                        break;

                    case 3:
                        RunTemperatureConverter();
                        break;

                    case 4:
                        RunCurrencyConverter();
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("\nThank you for using the application!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid menu option. Please choose 1 to 5.");
                        break;
                }
            }
        }

        static void RunCalculator()
        {
            Console.WriteLine("\n--- CALCULATOR ---");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = InputHelper.ReadMenuChoice(
                "Choose an operation: ");

            if (choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid operation.");
                return;
            }

            double firstNumber = InputHelper.ReadNumber(
                "Enter the first number: ");

            double secondNumber = InputHelper.ReadNumber(
                "Enter the second number: ");

            try
            {
                double result = choice switch
                {
                    1 => CalculatorFunctions.Add(firstNumber, secondNumber),
                    2 => CalculatorFunctions.Subtract(firstNumber, secondNumber),
                    3 => CalculatorFunctions.Multiply(firstNumber, secondNumber),
                    4 => CalculatorFunctions.Divide(firstNumber, secondNumber),
                    _ => 0
                };

                Console.WriteLine($"Result: {result:F2}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void RunDistanceConverter()
        {
            Console.WriteLine("\n--- DISTANCE CONVERTER ---");
            Console.WriteLine("1. Kilometres to Miles");
            Console.WriteLine("2. Miles to Kilometres");

            int choice = InputHelper.ReadMenuChoice(
                "Choose a conversion: ");

            double distance = InputHelper.ReadNumber(
                "Enter the distance: ");

            switch (choice)
            {
                case 1:
                    Console.WriteLine(
                        $"Result: {CalculatorFunctions.KilometresToMiles(distance):F2} miles");
                    break;

                case 2:
                    Console.WriteLine(
                        $"Result: {CalculatorFunctions.MilesToKilometres(distance):F2} kilometres");
                    break;

                default:
                    Console.WriteLine("Invalid conversion option.");
                    break;
            }
        }

        static void RunTemperatureConverter()
        {
            Console.WriteLine("\n--- TEMPERATURE CONVERTER ---");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            int choice = InputHelper.ReadMenuChoice(
                "Choose a conversion: ");

            double temperature = InputHelper.ReadNumber(
                "Enter the temperature: ");

            switch (choice)
            {
                case 1:
                    Console.WriteLine(
                        $"Result: {CalculatorFunctions.CelsiusToFahrenheit(temperature):F2} °F");
                    break;

                case 2:
                    Console.WriteLine(
                        $"Result: {CalculatorFunctions.FahrenheitToCelsius(temperature):F2} °C");
                    break;

                default:
                    Console.WriteLine("Invalid conversion option.");
                    break;
            }
        }

        static void RunCurrencyConverter()
        {
            Console.WriteLine("\n--- CURRENCY CONVERTER ---");
            Console.WriteLine("Ghanaian Cedis (GHS) to US Dollars (USD)");

            double cedis = InputHelper.ReadNumber(
                "Enter the amount in GHS: ");

            double exchangeRate = InputHelper.ReadNumber(
                "Enter how many GHS equal 1 USD: ");

            try
            {
                double result = CalculatorFunctions.GhanaCedisToUsd(
                    cedis, exchangeRate);

                Console.WriteLine($"Result: USD {result:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
