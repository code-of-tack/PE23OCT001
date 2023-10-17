
package javaEx;

import java.util.Scanner;

public class FactorialNumber {

	public class FactorialCalculator {
		public static long calculateFactorial(int n) {
			if (n == 0) {
				return 1;
			}
			return n * calculateFactorial(n - 1);
		}

		public static void main(String[] args) {
			Scanner scanner = new Scanner(System.in);
			System.out.print("Enter a number to calculate its factorial: ");
			int number = scanner.nextInt();
			scanner.close();
			if(n>=0)
			{long factorial = calculateFactorial(number);}
			else
			{
				system.out.println("Negetive number");
			}
			
			System.out.println("Factorial of " + number + " is " + factorial);
		}

	}
}
