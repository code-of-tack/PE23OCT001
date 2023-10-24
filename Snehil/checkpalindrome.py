def is_palindrome(input_string):
    """
    Function to check if a string is a palindrome.
    :param input_string: The string to be checked.
    :return: True if the string is a palindrome, False otherwise.
    """
    # Convert the input string to lowercase and remove whitespace
    formatted_string = input_string.lower().replace(" ", "")

    # Compare the original string with its reverse
    return formatted_string == formatted_string[::-1]

# Example usage
test_string = "A man a plan a canal Panama"
if is_palindrome(test_string):
    print(f"The string '{test_string}' is a palindrome.")
else:
    print(f"The string '{test_string}' is not a palindrome.")
