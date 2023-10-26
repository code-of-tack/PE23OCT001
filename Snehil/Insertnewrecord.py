import sqlite3

# Establish a connection to the SQLite database
conn = sqlite3.connect('example.db')
cursor = conn.cursor()

def insert_record(name, age, email):
    """
    Function to insert a new record into the database.
    :param name: Name of the person.
    :param age: Age of the person.
    :param email: Email address of the person.
    """
    try:
        # Use parameterized query to prevent SQL injection
        cursor.execute("INSERT INTO records (name, age, email) VALUES (?, ?, ?)", (name, age, email))
        conn.commit()
        print("Record inserted successfully.")
    except sqlite3.Error as e:
        print(f"An error occurred: {e}")


if __name__ == "__main__":
    # Take user input for the new record
    name = input("Enter name: ")
    age = int(input("Enter age: "))
    email = input("Enter email: ")

    # Call the function to insert the new record
    insert_record(name, age, email)

    # Close the database connection
    conn.close()
