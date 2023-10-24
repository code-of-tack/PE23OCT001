using System;

class StringManipulationDebug
{
    static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "world";
        
        // Concatenating two strings
        string result = str1 + " " + str2; // Added space between two strings
        Console.WriteLine("Concatenation result: " + result);

        // Finding the substring
        string sub = result.Substring(1, Math.Min(10, result.Length - 1)); // Added Math.Min to avoid going beyond the string length
        Console.WriteLine("Substring result: " + sub);

        // Changing the case
        string lowerCase = result.ToLower(); // Changed variable name to lowerCase
        Console.WriteLine("Lower case result: " + lowerCase);
        Console.ReadLine(); // To prevent console from closing
    }
}
