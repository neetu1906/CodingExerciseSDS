using System;
using DeveloperSample.Algorithms; 

class Program
{
    static void Main(string[] args)
    {
        
        int factorialOf5 = Algorithms.GetFactorial(5);
        Console.WriteLine("Factorial of 5 is: " + factorialOf5);

        string formattedString = Algorithms.FormatSeparators("a", "b", "c");
        Console.WriteLine("Formatted string: " + formattedString);
    }
}
