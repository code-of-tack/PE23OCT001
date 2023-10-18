package com.akash.service;

public class GCD {

    public class GCDCalculator {

        public static void main(String[] args) {
            int number1 = 40;
            int number2 = 10;

            int gcd = findGCD(number1, number2);

            System.out.println("GCD is: " + gcd);
        }
        public static int findGCD(int a, int b) {
            while (b != 0) {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

}
