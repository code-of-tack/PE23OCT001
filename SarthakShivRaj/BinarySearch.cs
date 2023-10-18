using System;
using System.Collections.Generic; 

class BinarySearch
{
    static void Main(string[] args)
    {
      //Declaring List arr to store numbers in Sorted order   
      List<int> arr = new List<int>();

        Console.Write("Enter how many numbers to store in the array: ");
      
        //Checking the number is valid or not
        if (int.TryParse(Console.ReadLine(), out int totalNumber))
        {
            Console.WriteLine("Enter the numbers: ");
            for (int i = 0; i < totalNumber; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    arr.Add(temp);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Decrement i to retry entering the number
                }
            }

            // At this point, 'arr' contains the list of integers.
        }
        else
        {
            Console.WriteLine("Invalid input for the total number of elements.");
        }
      
        Console.Write("Which number you want to find: ");
      
        if (int.TryParse(Console.ReadLine(), out int target))
        {
          // Calling Binary Search function and storing the index
          int index = binarySearch(arr,0,totalNumber-1,target);
          
          // Displaying the result
          Console.WriteLine($"The index target {target} was found in index {index}");
        }
        else{
            Console.WriteLine("Invalid input for target to find.");
        }
        
    }
      

    static int binarySearch(List<int> arr,int low, int high, int target)
    {
        int mid; 
        while(low<=high){
            // finding middle index of list
            mid = (low + high)/2;

            // if target is found then return
            if(arr[mid]==target){
                return mid;
            }
            // target is in left subpart
            else if(arr[mid] > target){
                high = mid - 1;
            }
            // target is in right subpart
            else{
                low = mid + 1;
            }
        }
        // if target is not in array then return -1
        return -1;
    }
}
