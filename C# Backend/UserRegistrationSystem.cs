using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationSystem
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"User: {Username}";
        }
    }

    public class UserRegistrationSystem
    {
        private Dictionary<string, User> users;
        private readonly Regex usernamePattern;
        private readonly Regex passwordPattern;

        public UserRegistrationSystem()
        {
            users = new Dictionary<string, User>();
            usernamePattern = new Regex("^[a-z0-9]{1,}$");
            passwordPattern = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=\\S+$).{8,}$");
        }

        public bool RegisterUser(string username, string password)
        {
            if(!IsUsernameValid(username))
                return false;
            
            var newUser = new User(username, password);
            users.Add(username, newUser);
            return true;
        }

        private bool IsUsernameValid(string username)
        {
            return usernamePattern.IsMatch(username);
        }

        private bool IsPasswordValid(string password)
        {
            return true; // Implement Logic
        }

        private bool IsDuplicateUsername(string username)
        {
            return true; // Implement Logic
        }
        
        static void Main(string[] args)
        {
            
            // Example usage
            var system = new UserRegistrationSystem();
            Console.WriteLine(system.RegisterUser("user123", "Password123")); // should return true
            Console.WriteLine(system.RegisterUser("user123", "password123")); // should return false
            Console.WriteLine(system.RegisterUser("user1", "pass")); // should return false
        }
    }
}
