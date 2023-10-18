using System;

class FactorialCalculator
{
    public static int Factorial(int number)
    {
        if (number == 0 || number == 1)
            return 1;
        else
            return number * Factorial(number - 1);
    }
  
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Please enter a positive integer.");
            }
            else
            {
                int result = Factorial(input);
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
        Console.ReadLine(); 
    }
}
