using System;

class FactorialCalculator
{
    // Recursive function to calculate factorial
    public static int CalculateFactorial(int number)
    {
        // Base case
        if (number == 0 || number == 1)
            return 1;
        else
            return number * CalculateFactorial(number - 1);
    }

    // Main method to run the program
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number to calculate its factorial: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Please enter a non-negative integer.");
            }
            else
            {
                int result = CalculateFactorial(input);
                Console.WriteLine($"Factorial of {input} is: {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input is too large to handle.");
        }
        Console.ReadLine(); // To prevent console from closing
    }
}
