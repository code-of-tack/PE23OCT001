// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class GCD
{
    
    public static int FINDGCD(int a, int b){
    // Base case
    if (b == 0) 
        return a;
    // Optimized Euclid's Algorithm recursive.
    return FINDGCD(b, a%b);
    }

    // Main method to test GCD calculation
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 0 || num2 < 0)
            {
                Console.WriteLine("Please enter non-negative integers.");
            }
            else
            {
                int gcd = FINDGCD(num1, num2);
                Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid integers.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input is too large to handle.");
        }
        Console.ReadLine(); // To prevent console from closing
    }
}
