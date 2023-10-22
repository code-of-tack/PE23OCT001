my_list = [1, 2, 3, 4, 5]

try:
    print(my_list[10])
except IndexError as e:
    print(f"An error occurred: {e}. The index is out of range.")
