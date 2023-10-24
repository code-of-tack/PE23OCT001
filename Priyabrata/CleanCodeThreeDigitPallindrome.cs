using System;
using System.Collections.Generic;

internal class q5
{
    
    public static void threeDigitPalindrome()
    {
        for (int i = 100;i<1000;i++) 
        {
            //print if 1st and 3rd digit are equal
            if(i%10==i/100) Console.WriteLine(i);
        }
    }

    //faster implementation using pattern of 3 digit palindrome numbers
    //101 111 121...191 increment by 10
    //191 202...292 303 increment by 11
    public static void threeDigitPalindromeMathImplementation() 
    {
        int num = 101;
        for(int i = 1; i < 10; i++)
        {
            for(int j = 1; j < 11; j++)
            {
                Console.WriteLine(num);
                num += 10;
            }
            num += 1;
        }
    }
    
    //Main method
    public static void Main(string[]args)
    {
        threeDigitPalindrome();
        threeDigitPalindromeMathImplementation();
    }
}
