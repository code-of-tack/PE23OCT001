using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Three-digit palindromic numbers:");
        
        for (int number = 100; number <= 999; number++)
        {
            if (IsPalindrome(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    // Function to check if a number is a palindrome
    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reverse = 0;
        
        while (number > 0)
        {
            int remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number /= 10;
        }

        return originalNumber == reverse;
    }
}
