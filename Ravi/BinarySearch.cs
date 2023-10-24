using system;
class BinarySearch
{
    // Method to perform binary search on a sorted array
    public static int PerformBinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid; // Element found at index mid
            }
            else if (arr[mid] < target)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }

        return -1; // Element not found
    }

    // Main method to test binary search
    static void Main(string[] args)
    {
        int[] sortedArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int target = 10;

        int result = PerformBinarySearch(sortedArray, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}.");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array.");
        }
        Console.ReadLine(); // To prevent console from closing
    }
}
