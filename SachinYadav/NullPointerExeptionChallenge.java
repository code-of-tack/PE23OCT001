package Exercise2;

/*
 * This is debugging exercise-02 of project earlybird
 * The corrected code after debugging and adding exception handling
 * @author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class NullPointerExceptionChallenge {

    public static void main(String[] args) {
        // String str = "Sachin" it will work fine because the string is not null
        // String str = null; // gives NullPointerExepception because str is empty 
        String str = null;
        try {
            if(str != null)
            {    
                int length = str.length();
                System.out.println("Length of the string: " + length);
            }else{
                System.out.println("String is null.");
            }
        } catch (NullPointerException nullPointerException) {
            System.out.println("String is null. Please provide the non-null string");
        }


    }
}
