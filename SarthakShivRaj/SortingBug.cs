using System;

class SortingBug
{
    // Custom sorting algorithm
    public static void CustomSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++) // Updated condition
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[i])
                {
                    // Swap the elements
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    // Main method to test sorting
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 8, 4, 1, 9, 3, 7, 6 };
        Console.WriteLine("Original Array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }

        CustomSort(array);

        Console.WriteLine("\nSorted Array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.ReadLine(); // To prevent console from closing
    }
}
