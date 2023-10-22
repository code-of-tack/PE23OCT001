using System;

class MathematicalCalculationDebug
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 2;
        
        // Performing addition
        int sum = a + b;
        Console.WriteLine("Sum: " + sum);

        // Performing division with double type for accurate results
        double division = (double)a / b;
        Console.WriteLine("Division: " + division);

        // Performing multiplication
        int product = a * b;
        Console.WriteLine("Product: " + product);

        // Performing subtraction
        int difference = a - b;
        Console.WriteLine("Difference: " + difference);

        // Performing modulo
        int modulo = a % b;
        Console.WriteLine("Modulo: " + modulo);

        Console.ReadLine(); // To prevent console from closing
    }
}
