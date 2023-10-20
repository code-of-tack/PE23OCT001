package Exercise5;

public class LoopLogicBugHunt {

    public static void main(String[] args) {
        int n = 5;

        // Print numbers from 1 to n
        System.out.print("Numbers from 1 to " + n + ": ");
        for (int i = 1; i <= n; i++) {
            System.out.print(i + " ");
        }

        // Print even numbers from 1 to n
        System.out.print("\nEven numbers from 1 to " + n + ": ");
        //change the initialization to i = 2 and increment by 2 for updation to get even numbers only
        for (int i = 2; i <= n; i+=2) {
            System.out.print(i + " ");
        }

        // Print odd numbers from 1 to n
        System.out.print("\nOdd numbers from 1 to " + n + ": ");
        //change the updation from i++ to i+=2 
        for (int i = 1; i <= n; i+=2) {
            System.out.print(i + " ");
        }
    }
}
