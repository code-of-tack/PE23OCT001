def main():
    try:
        # Attempting to call a non-existent function
        non_existent_function()
    except NameError as e:
        print(f"An error occurred: {e}. The function does not exist.")

if __name__ == "__main__":
    main()
