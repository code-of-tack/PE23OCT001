using System;

class NullPointerExceptionChallenge
{
    static void Main(string[] args)
    {
        string str = null;

        if (str != null)
        {
            int length = str.Length;
            Console.WriteLine("Length of the string is: " + length);
        }
        else
        {
            Console.WriteLine("The string is null.");
        }

        Console.ReadLine(); // To prevent console from closing
    }
}
