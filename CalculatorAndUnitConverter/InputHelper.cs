
using System;
using System.Globalization;

namespace CalculatorAndUnitConverter
{
    public static class InputHelper
    {
        public static double ReadNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out double number) &&
                    double.IsFinite(number))
                {
                    return number;
                }

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public static int ReadMenuChoice(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    return choice;
                }

                Console.WriteLine("Invalid choice. Please enter a number.");
            }
        }
    }
}
