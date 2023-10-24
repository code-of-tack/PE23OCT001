using System;

class LoopLogicBugHunt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Printing numbers from 1 to 5:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nPrinting even numbers from 1 to 10:");
        for (int j = 2; j <= 10; j += 2)
        {
            Console.Write(j + " ");
        }

        Console.WriteLine("\nPrinting odd numbers from 1 to 10:");
        for (int k = 1; k < 10; k += 2)
        {
            Console.Write(k + " ");
        }

        Console.ReadLine(); // To prevent console from closing
    }
}
