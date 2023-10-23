import pyodbc
from tabulate import tabulate
import pandas as pd
# SQL Server connection details
server = 'DESKTOP-T2MIRLG'
database = 'veersa'


#SQL query
query = 'SELECT * FROM customers'

try:
    #connection to the SQL Server database
    conn = pyodbc.connect(f'DRIVER={{SQL Server}};SERVER={server};DATABASE={database};')
    
    # Execute the query and fetch the results into a DataFrame
    df = pd.read_sql_query(query, conn)

    # Close the database connection
    conn.close()

    # Check if there are any results
    if not df.empty:
        print(df)
    else:
        print("No data found in the table.")
except pyodbc.Error as e:
    print(f"An error occurred: {e}")
