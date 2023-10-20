package com.eshop.project.repository;

public class CleanCode5 {
        public static void main(String[] args) {
            System.out.println("Three-digit palindromic numbers are:");

            for (int number = 100; number <= 999; number++) {
                if (isPalindrome(number)) {
                    System.out.println(number);
                }
            }
        }

    /**
     * Check if the number is palindrome
     * @param number to check is paindrome
     * @return True/false is palindrome or not
     */
    public static boolean isPalindrome(int number) {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0) {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }

}
