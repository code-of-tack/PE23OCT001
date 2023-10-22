using System;
     
class ThreeDigitPalindrome
{
     
    // Function to return the 
    // reverse of num 
    static int reverse(int num) 
    { 
        int rev = 0; 
        while (num > 0) 
        { 
            rev = rev * 10 + num % 10; 
            num = num / 10; 
        } 
        return rev; 
    } 
     
    // Function that returns true 
    // if num is palindrome 
    static bool isPalindrome(int num) 
    { 
     
        // If the number is equal to the 
        // reverse of it then it 
        // is a palindrome 
        if (num == reverse(num)) 
            return true; 
     
        return false; 
    } 
     
    // Function to print all the 
    // d-digit palindrome numbers 
    static void printPalindromes(int d) 
    { 
        if (d <= 0) 
            return; 
     
        // Smallest and the largest d-digit numbers 
        int smallest = (int)Math.Pow(10, d - 1); 
        int largest = (int)Math.Pow(10, d) - 1; 
     
        // Starting from the smallest d-digit 
        // number till the largest 
        for (int i = smallest; i <= largest; i++)
        { 
 
            // If the current number 
            // is palindrome 
            if (isPalindrome(i)) 
                Console.Write(i + " "); 
        } 
    } 
     
    // Driver code 
    public static void Main (String[] args)
    { 
        int d = 3; 
     
        printPalindromes(d); 
    } 
}
