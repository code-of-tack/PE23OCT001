package Exercise6;

import java.util.HashMap;
import java.util.Map;
import java.util.regex.Pattern;

/*
 * This is user class which has username and password
 * @author - Sachin Yadav
 * @organization - Veersa Technologies
 */
class User {
    private final String username;
    private final String password;

    public User(String username, String password) {
        this.username = username;
        this.password = password;
    }

    public String getUsername() {
        return username;
    }

    public String getPassword() {
        return password;
    }

    @Override
    public String toString() {
        return "User{" + "username='" + username + '\'' + ", password='" + password + '\'' + '}';
    }
}

/*
 * User Registration System to register the user with username and password validation
 */
public class UserRegistrationSystem {
    private final Map<String, User> users;
    private final Pattern usernamePattern;
    private final Pattern passwordPattern;

    public UserRegistrationSystem() {
        this.users = new HashMap<>();
        //regex to check  username  in all lowercase letters with alphanumeric values
        this.usernamePattern = Pattern.compile("^[a-z0-9]+$");
        //regex to check password with  one capital letter, and special character (@#$%) and should be at-least 6 characters long
        this.passwordPattern = Pattern.compile("^(?=.*[A-Z])(?=.*[@#$%]).{6,}$");
    }

    public boolean registerUser(String username, String password) {
        if (!isUsernameValid(username) || !isPasswordValid(password) || isDuplicateUsername(username)) {
            return false;
        }

        User newUser = new User(username, password);
        users.put(username, newUser);
        return true;
    }

    boolean isUsernameValid(String username) {
        return usernamePattern.matcher(username).matches();
    }

    boolean isPasswordValid(String password) {
        return passwordPattern.matcher(password).matches();
    }

    boolean isDuplicateUsername(String username) {
        return users.containsKey(username);
    }

    public static void main(String[] args) {
        // Example usage
        UserRegistrationSystem system = new UserRegistrationSystem();
        System.out.println(system.registerUser("user123", "Password@123")); // should return true
        System.out.println(system.registerUser("user123", "password123")); // should return false
        System.out.println(system.registerUser("user1", "pass")); // should return false
        System.out.println(system.registerUser("user123","Sachin@0278")); //should return false
    }
}
