using System;

internal class q1
{
    public static int Factorial(int num,int ans)
    {
        //base condition
        if(num == 0) return ans;

        ans *= num;
        //recursively calling function
        return Factorial(num - 1, ans);
        
    }
    
    //main method to test the function
    static void Main(string[]args)
    {
        Console.Write("Enter number to find factorial : ");
        try
        {
            int num = Convert.ToInt32(Console.ReadLine());
            //exception if input is negative
            if(num<0)
                throw new Exception("negative number");
            
            int ans = q1.Factorial(num,1);
            Console.WriteLine("Factorial of "+num+" : "+ans);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input is too large to handle.");
        }
        catch (Exception ex)
        {
            System.Diagnostics.Trace.WriteLine("Exception");
            throw;
        }
    }
}
