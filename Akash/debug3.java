public class StringManipulationDebug {
    public static void main(String[] args) {
        String str1 = "Hello";
        String str2 = "world";

        // Concatenating two strings
        String result = str1 + str2;
        System.out.println("Concatenation result: " + result);

        // Finding the substring
        int endIndex = Math.min(11, result.length()); 
        String sub = result.substring(1, endIndex);
        System.out.println("Substring result: " + sub);

        // Changing the case
        String lowerCase = result.toLowerCase();
        System.out.println("Lower case result: " + lowerCase);
    }
}
