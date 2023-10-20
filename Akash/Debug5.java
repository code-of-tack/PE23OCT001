package com.eshop.project.repository;

public class LoopLogicBugHunt {

    public static void main(String[] args) {
        int n = 5;

        // Print numbers from 1 to n
        System.out.print("Numbers from 1 to " + n + ": ");
        for (int i = 1; i <= n; i++) {
            System.out.print(i + " ");
        }
        System.out.println();


        // Print even numbers from 1 to n
        System.out.print("\nEven numbers from 1 to " + n + ": ");
        for (int i = 1; i <= n; i++) {
            if (i % 2 == 0) {
                System.out.print(i + " ");
            }
        }
        System.out.println();

        // Print odd numbers from 1 to n
        System.out.print("\nOdd numbers from 1 to " + n + ": ");
        for (int i = 1; i <= n; i++) {
            if (i % 2 != 0) {
                System.out.print(i + " ");
            }
        }
        System.out.println();
    }
}
