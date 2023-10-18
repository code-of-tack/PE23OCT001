using System;
using System.Collections.Generic;
    internal class q2
    {
        public static int GCD(int num1, int num2 )
        {
            // if either number is 0 return the other number
            if (num1 == 0)
                return num2;
            if (num2 == 0)
                return num1;
            
            //putting the greater number in num1
            if (num2 > num1)
            {
                int temp = num2;
                num2 = num1;
                num1 = temp;
            }

            int remainder;
            remainder = num1 % num2;

            //recursively calling the function with the smaller number and the remainder
            return GCD(num2, remainder);


        }
        static void Main(string[] args)
        {
            Console.Write("num 1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("num 2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int ans = q2.GCD(n1, n2);
            Console.WriteLine("GCD : " + ans);
        }
    }
