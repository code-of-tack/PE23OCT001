using System;

class GCDCalculator
{
    static void Main(string[] args)
    {
        try{
          Console.WriteLine("Enter two numbers to find their greatest common divisor (GCD):");
          Console.WriteLine("Enter the first number: ");
          int number1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter the second number: ");
          int number2 = Convert.ToInt32(Console.ReadLine());
          int gcd=0;

          // input numbers
          if(number1 < 0 || number2 < 0){
              //invalid number
              Console.WriteLine("Please enter non negative number");
          }
          else if (number1 < number2)
          {
              // Calculate GCD using Euclidean algorithm
              gcd = CalculateGCD(number1, number2);   
          }
          else
          {
              gcd = CalculateGCD(number2, number1);
          }
          // Display the result
          Console.WriteLine($"The GCD of {number1} and {number2} is {gcd}");
          }
      
      catch (FormatException)
          {
              Console.WriteLine("Please enter valid integers.");
          }
      catch (OverflowException)
          {
              Console.WriteLine("Input is too large to handle.");
          }
      }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

}
