package Exercise4;

/*
 * This is exercise 4 of debugging exercise by project earlybird
 * @Author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class MathematicalCalculationErrors {

    public static void main(String[] args) {
        int a = 5;
        int b = 0;

        // Performing division
        if (b != 0 && a != 0) {
            int divisionResult = a / b;
            System.out.println("Division Result: " + divisionResult);
        } else if (a == 0) {
            System.out.println("Numerator and denominator both are zero which leads to indeterminate form (0/0).");
        } else {
            System.out.println("The Denominator is 0 so, division is not possible. Please provide non-zero number.");
        }
        
        // Computing power
        double powerResult = Math.pow(a, b);
        System.out.println("Power Result: " + powerResult);

        // Taking square root
        int num = -9;
        double sqrtResult = 0;
        if (num >= 0) {
            sqrtResult = Math.sqrt(num);
        } else {
            //for negative numbers assigning NaN
            sqrtResult = Double.NaN;
        }
        System.out.println("Square Root Result: " + sqrtResult);
    }
}
