using System;
using System;

class NullPointerExceptionChallenge
{
    static void Main(string[] args)
    {
        string str = null;
        int length = 0;
      
        if (str == null)
        {
            Console.WriteLine("The string is null.");
        }
        else
        {
            length = str.Length;
        }

        Console.WriteLine("Length of the string is: " + length);
        Console.ReadLine(); // To prevent console from closing
    }
}
