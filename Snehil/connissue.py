import sqlite3

def connect_to_database(db_name):
    """
    Function to establish a connection to an SQL database.
    :param db_name: Name of the database.
    """
    try:
        conn = sqlite3.connect(db_name)
        print("Connection to the database established successfully.")
        conn.close()
    except sqlite3.Error as e:
        print(f"An error occurred: {e}")

# Call the function with the database name
connect_to_database('example.db')
