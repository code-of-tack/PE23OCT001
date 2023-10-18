package Exercise3;

import java.util.Scanner;

/*
 * This is Exercise 3 of clean code practice by project earlybird
 * @Author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class BinarySearch {
    public static void main(String[] args) {
        try {
            Scanner scanner = new Scanner(System.in);
            System.out.println("Enter the size of the array: ");
            int sizeOfArray = scanner.nextInt();
            int[] sortedArray = new int[sizeOfArray];
            System.out.println("Enter the elements of the array in sorted order : ");
            for (int i = 0; i < sizeOfArray; i++) {
                sortedArray[i] = scanner.nextInt();
            }

            System.out.println("Enter the element to search : ");
            int elementToSearch = scanner.nextInt();

            int positionOfSearchElement = binarySearch(sortedArray, elementToSearch);
            if (positionOfSearchElement != -1)
                System.out.println("The element with the value " + elementToSearch + " is found at position " + positionOfSearchElement + " .");
            else 
                System.out.println("No element with the value " + elementToSearch + " does not exist in the array.");
        } catch (Exception e) {
            System.out.println("An error occurred: " + e.getMessage());
        } 
    }

    /*
     * Function to implement binary search algorithm to search an element in the sorted array
     * @params - {int[]} sortedArray - an array of elements in sorted order
     * @params - {int} elementToSearch - an element to search on the sortedArray
     * @returns - {int} - position of the found element
     */
    private static int binarySearch(int[] sortedArray, int elementToSearch) {
        int size = sortedArray.length;
        int low = 0;
        int high = size - 1;
        while (low <= high) {
            int mid = (low + (high - low) / 2);
            if (sortedArray[mid] == elementToSearch) {
                return mid;
            } else if (sortedArray[mid] < elementToSearch) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return -1;
    }
}
