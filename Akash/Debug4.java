public class MathematicalCalculationErrors {

    public static void main(String[] args) {
        int a = 5;
        int b = 0;

        if (b != 0) {
            int divisionResult = a / b;
            System.out.println("Division Result: " + divisionResult);
        } else {
            System.out.println("Division by zero is not allowed.");
        }
]
        double powerResult = Math.pow(a, b);
        System.out.println("Power Result: " + powerResult);

        double numberToSquareRoot = -9;
        if (numberToSquareRoot >= 0) {
            double sqrtResult = Math.sqrt(numberToSquareRoot);
            System.out.println("Square Root Result: " + sqrtResult);
        } else {
            System.out.println("Square root of a negative number is not allowed.");
        }
    }
}
