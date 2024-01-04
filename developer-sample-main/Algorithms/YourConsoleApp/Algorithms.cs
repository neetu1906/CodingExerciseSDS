using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        // Method to calculate the factorial of a given number
        public static int GetFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial of negative number is not defined.");
            }

            if (n == 0)
            {
                return 1;
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        // Method to format a string array into a single string with separators
        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }

            if (items.Length == 1)
            {
                return items[0];
            }

            var result = string.Join(", ", items, 0, items.Length - 1);
            result += " and " + items[^1];
            
            return result;
        }
    }
}
