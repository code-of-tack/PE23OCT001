import sqlite3

# Establish a connection to the SQLite database
conn = sqlite3.connect('example.db')
cursor = conn.cursor()

# Create the 'records' table if it doesn't exist
cursor.execute('''
    CREATE TABLE IF NOT EXISTS records (
        id INTEGER PRIMARY KEY,
        name TEXT NOT NULL,
        age INTEGER,
        email TEXT
    )
''')

# Attempt to insert data into the 'records' table
try:
    cursor.execute("INSERT INTO records (name, age, email) VALUES (?, ?, ?)", ('John Doe', 30, 'johndoe@example.com'))
    conn.commit()
    print("Data inserted successfully.")
except sqlite3.IntegrityError as e:
    conn.rollback()  # Rollback changes if there's an error
    print(f"Integrity constraint violation: {e}")
except sqlite3.Error as e:
    conn.rollback()  # Rollback changes for other errors
    print(f"An error occurred: {e}")

# Close the database connection
conn.close()
