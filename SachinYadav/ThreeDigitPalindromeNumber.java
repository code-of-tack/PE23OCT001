package Exercise5;

/*
 * This is Exercise 5 of the best coding practice by project earlybird
 * @Author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class ThreeDigitPalindromeNumber {
    public static void main(String[] args) {
        int digit = 3;
        printThreeDigitPalindrome(digit);

    }

    /*
     * Function to print all the three digit palindrome number
     * @params - {int} digit - a number representing the digit of the number
     * @returns - void - no return type
     */
    private static void printThreeDigitPalindrome(int digit) {
        int smallestValue = (int) Math.pow(10, digit - 1);
        int largestValue = (int) Math.pow(10, digit) - 1;

        for (int value = smallestValue; value <= largestValue; value++) {
            if (isPalindrome(value)) {
                System.out.print(value + " ");
            }
        }
    }

    /*
     * Function to check whether the given number is palindrome or not
     * @params - {int} value - an integer number
     * @returns boolean value
     */
    private static boolean isPalindrome(int value) {
        int originalNumber = value;
        int reverseValue = 0;
        while (value > 0) {
            reverseValue = reverseValue * 10 + (value % 10);
            value /= 10;
        }
        return originalNumber == reverseValue;
    }
}
