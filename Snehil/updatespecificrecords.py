import sqlite3

# Establish a connection to the SQLite database
conn = sqlite3.connect('example.db')
cursor = conn.cursor()

def update_record():
    """
    Function to update a record in the database based on user input.
    """
    try:
        # Prompt the user for the name to search for
        name_to_update = input("Enter the name of the record to update: ")

        # Check if the record exists in the database
        cursor.execute("SELECT * FROM records WHERE name=?", (name_to_update,))
        existing_record = cursor.fetchone()

        if existing_record is not None:
            # Record found, prompt for new data
            new_name = input("Enter the new name (leave empty to keep the current name): ")
            new_age = input("Enter the new age (leave empty to keep the current age): ")
            new_email = input("Enter the new email (leave empty to keep the current email): ")

            # Construct an SQL query to update the record
            update_query = "UPDATE records SET "
            update_values = []

            if new_name:
                update_query += "name=?, "
                update_values.append(new_name)

            if new_age:
                update_query += "age=?, "
                update_values.append(new_age)

            if new_email:
                update_query += "email=?, "
                update_values.append(new_email)

            # Remove the trailing comma and add the WHERE clause
            update_query = update_query.rstrip(", ") + " WHERE name = ?"
            update_values.append(name_to_update)

            # Execute the update query with parameterized values
            cursor.execute(update_query, update_values)
            conn.commit()

            print("Record updated successfully.")
        else:
            print(f"Record with name '{name_to_update}' not found in the database.")

    except sqlite3.Error as e:
        print(f"An error occurred: {e}")
    finally:
        # Close the database connection
        conn.close()

if __name__ == "__main__":
    update_record()
