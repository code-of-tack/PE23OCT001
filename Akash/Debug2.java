public class NullPointerExceptionChallenge {

    public static void main(String[] args) {
        String str = null;
        if (str != null) {
            int length = str.length();
            System.out.println("Length of the string: " + length);
        } else {
            System.out.println("The string is null.");
        }
    }
}
