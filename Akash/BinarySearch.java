package com.example.cruddto.service;

public class BinarySearch {

    /**
     *
     * @param arr the array
     * @param target the search element
     * @return the index if found, -1 iif not found
     */
    public static int binarySearch(int[] arr, int target) {
        int left = 0;
        int right = arr.length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target) {
                return mid;
            }
            if (arr[mid] > target) {
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }
        return -1;
    }


    public static void main(String[] args) {
        int[] arr = {2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91};
        int target = 23;
        int result = binarySearch(arr, target);

        if (result != -1) {
            System.out.println("Element found at index " + result);
        } else {
            System.out.println("Element not found in the array");
        }
    }
}
