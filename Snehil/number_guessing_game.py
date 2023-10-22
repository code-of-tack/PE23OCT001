import random

def guess_the_number():
    print("Welcome to the Guess the Number Game!")
    print("I am thinking of a number between 1 and 100. Try to guess it.")

    random_number = random.randint(1, 100)
    attempts = 0
    max_attempts = 5

    while attempts < max_attempts:
        try:
            guess = int(input("Enter your guess: "))
            attempts += 1

            if guess < random_number:
                print("Your guess is too low. Try again!")
            elif guess > random_number:
                print("Your guess is too high. Try again!")
            else:
                print(f"Congratulations! You guessed the number {random_number} correctly in {attempts} attempts!")
                break

        except ValueError:
            print("Invalid input. Please enter a valid number.")

    if attempts == max_attempts:
        print(f"Sorry, you've reached the maximum number of attempts. The number was {random_number}.")

if __name__ == "__main__":
    guess_the_number()
