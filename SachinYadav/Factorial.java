import java.util.Scanner;

/*
 * This is the exercise-01 of the best coding practice by project early bird
 * @Author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class Factorial {

    //Creating recursive factorial method to calculate the factorial of any number
    private static int factorial(int num) {
        //base case
        if (num <= 1) return 1;
        //recursive call of factorial function
        return num * factorial(num - 1);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the number whose factorial is to be calculated: ");
        int num = Integer.parseInt(scanner.nextLine());
        //calling the factorial function
        int factorialOfNum = factorial(num);
        //printing the output
        System.out.println("The factorial of " + num + " is " + factorialOfNum);

    }
}
