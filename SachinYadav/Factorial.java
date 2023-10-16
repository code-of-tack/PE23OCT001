package Exercise1;

import java.util.Scanner;

/*
 * This is the exercise-01 of the best coding practice by project early bird
 * @Author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class Factorial {
    
    //recursive factorial function
    private static int factorial(int num) {
        if (num < 0) {
            throw new IllegalArgumentException("Input must be a non-negative integer.");
        }
        if (num <= 1) return 1;
        return num * factorial(num - 1);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        try {
            System.out.println("Enter the number whose factorial is to be calculated: ");
            int num = Integer.parseInt(scanner.nextLine());
            int factorialOfNum = factorial(num);
            System.out.println("The factorial of " + num + " is " + factorialOfNum);
        } catch (NumberFormatException e) {
            //System.err.println will print it in red color denoting it as error
            System.err.println("Invalid input: Please provide a valid integer.");
        } catch (IllegalArgumentException e) {
            System.err.println(e.getMessage());
        }
    }
}
