import math

def calculate_square_root(number):
    try:
        number = float(number)
        if number < 0:
            raise ValueError("Cannot calculate square root of a negative number")
        return math.sqrt(number)
    except (ValueError, TypeError) as e:
        return f"Error: {e}. Please provide a valid number."

# Example usage
input_number = "25"
print(calculate_square_root(input_number))
