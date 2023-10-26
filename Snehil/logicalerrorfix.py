import sqlite3

# Establish a connection to the SQLite database
conn = sqlite3.connect('example.db')
cursor = conn.cursor()

# SQL query to retrieve data
query = "SELECT * FROM records WHERE age = ?"
age_param = (30,)

# Execute the query with parameterized values and fetch the results
results = cursor.execute(query, age_param).fetchall()

# Print the results
print(results)
