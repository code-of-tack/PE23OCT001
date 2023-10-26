package Exercise6;

import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

/*
 * Unit testing
 * @author - Sachin Yadav
 * @organization - Veersa Technologies
 */
public class UserRegistrationSystemTest {
    private UserRegistrationSystem system;

    @Before
    public void setUp() {
        system = new UserRegistrationSystem();
    }

    @Test
    public void testRegisterUserValidUsername() {
        assertTrue(system.registerUser("user123", "Password@123"));
    }

    @Test
    public void testRegisterUserDuplicateUsername() {
        system.registerUser("user123", "Password123");
        assertFalse(system.registerUser("user123", "password123"));
    }

    @Test
    public void testRegisterUserInvalidUsername() {
        assertFalse(system.registerUser("user@123", "Password123"));
    }

    @Test
    public void testRegisterUserValidPassword() {
        assertTrue(system.registerUser("user123", "Password@123"));
    }

    @Test
    public void testRegisterUserInvalidPassword() {
        assertFalse(system.registerUser("user123", "pass")); // This should return false
    }

}
