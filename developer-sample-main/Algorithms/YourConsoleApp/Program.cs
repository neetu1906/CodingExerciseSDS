using System;
using DeveloperSample.Algorithms; // Replace with your actual namespace

class Program
{
    static void Main(string[] args)
    {
        // Example of calling a method from Algorithms.cs
        int factorialOf5 = Algorithms.GetFactorial(5);
        Console.WriteLine("Factorial of 5 is: " + factorialOf5);

        string formattedString = Algorithms.FormatSeparators("a", "b", "c");
        Console.WriteLine("Formatted string: " + formattedString);
    }
}
