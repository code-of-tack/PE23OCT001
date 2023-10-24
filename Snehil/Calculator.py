def add(x, y):
    """Function to add two numbers"""
    return x + y

def subtract(x, y):
    """Function to subtract two numbers"""
    return x - y

def multiply(x, y):
    """Function to multiply two numbers"""
    return x * y

def divide(x, y):
    """Function to divide two numbers"""
    if y == 0:
        raise ValueError("Cannot divide by zero")
    return x / y

def calculator():
    """Simple calculator program"""
    print("Welcome to the Simple Calculator Program!")
    print("Select operation:")
    print("1. Addition")
    print("2. Subtraction")
    print("3. Multiplication")
    print("4. Division")

    while True:
        try:
            choice = input("Enter operation choice (1/2/3/4): ")
            if choice in ('1', '2', '3', '4'):
                num1 = float(input("Enter first number: "))
                num2 = float(input("Enter second number: "))

                if choice == '1':
                    print(f"Result: {num1} + {num2} = {add(num1, num2)}")
                elif choice == '2':
                    print(f"Result: {num1} - {num2} = {subtract(num1, num2)}")
                elif choice == '3':
                    print(f"Result: {num1} * {num2} = {multiply(num1, num2)}")
                elif choice == '4':
                    print(f"Result: {num1} / {num2} = {divide(num1, num2)}")
                break
            else:
                print("Invalid input. Please select a valid operation.")

        except ValueError as e:
            print(f"Invalid input: {e}. Please enter a valid number.")

if __name__ == "__main__":
    calculator()
