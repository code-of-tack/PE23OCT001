using System;
using System.Collections.Generic;

    internal class q3
    {
        public static void binarySearch(List<int> sortedList,int searchNum)
        {
            //loop runs till we have 1 element
            while (sortedList.Count > 1)
            {
                //find the floor mid index
                int mid = Convert.ToInt32(Math.Floor((decimal)sortedList.Count / 2));

                //if number at mid index, return found
                if (searchNum == sortedList[mid])
                {
                    Console.WriteLine("number found");
                    return;
                }

                //if number is larger than number at mid index, remove the left half of the list
                if (searchNum > sortedList[mid])
                    sortedList.RemoveRange(0,mid);
                
                //else number is smaller than number at mid index, remove the right half of the list
                else
                {
                    //since we are using floor to find mid index, we have an extra element in the right side
                    //of the list if the number of elements in the list is odd
                    if(sortedList.Count %2==0)
                        sortedList.RemoveRange(mid - 1, mid);
                    else
                        sortedList.RemoveRange(mid - 1, mid+1);
                }
                    
            }
            //loop  exits when a single number is left and we state number is not found
            Console.WriteLine("number not found");
        }
        static void Main(string[]args)
        {
            //sample list and number to test the function
            List<int> arr = new List<int>();
            for (int i = 0; i < 10; i++)
                arr.Add(i);
            q3.binarySearch(arr,9);
        }
        
    }

