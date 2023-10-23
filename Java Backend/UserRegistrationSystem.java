import java.util.HashMap;
import java.util.Map;
import java.util.regex.Pattern;

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
        return "User{" +
                "username='" + username + '\'' +
                ", password='" + password + '\'' +
                '}';
    }
}

public class UserRegistrationSystem {
    private final Map<String, User> users;
    private final Pattern usernamePattern;
    private final Pattern passwordPattern;

    public UserRegistrationSystem() {
        this.users = new HashMap<>();
        this.usernamePattern = Pattern.compile("^[a-zA-Z0-9]+$");
        this.passwordPattern = Pattern.compile("^[a-zA-Z0-9]+$");
    }

    public boolean registerUser(String username, String password) {
        if (!isUsernameValid(username) || !isPasswordValid(password) || isDuplicateUsername(username)) {
            return false;
        }

        User newUser = new User(username, password);
        users.put(username, newUser);
        return true;
    }

    private boolean isUsernameValid(String username) {
        return usernamePattern.matcher(username).matches();
    }

    private boolean isPasswordValid(String password) {
        return passwordPattern.matcher(password).matches();
    }

    private boolean isDuplicateUsername(String username) {
        return users.containsKey(username);
    }

    public static void main(String[] args) {
        // Example usage
        UserRegistrationSystem system = new UserRegistrationSystem();
        System.out.println(system.registerUser("user123", "Password123")); // should return true
        System.out.println(system.registerUser("user123", "password123")); // should return false
        System.out.println(system.registerUser("user1", "pass")); // should return false
    }
}
