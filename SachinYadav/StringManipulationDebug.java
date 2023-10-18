package Exercise3;

/*
 * This is Exercise 3 of debugging
 * The corrected code after debugging
 * @Author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class StringManipulationDebug {
    public static void main(String[] args) {
        String str1 = "Hello";
        String str2 = "world";

        // Concatenating two strings
        String result = str1 + " " +str2; //added space between two Strings
        System.out.println("Concatenation result: " + result);

        // Finding the substring
        String sub = result.substring(1); // Java substring takes the end index exclusive so, no need to mention the end index.
        System.out.println("Substring result: " + sub);

        // Changing the case
        String lowerCase = result.toLowerCase();
        System.out.println("Upper case result: " + lowerCase);
    }
}
