using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Assignment_97_Rawipote_P
{
    internal class DataAccess
    {
        public async static void InitializeDatabase()
        {
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Customers (UID INTEGER PRIMARY KEY, " +
                    "first_Name CHARACTER(40) NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
        }
        public static void AddData(string inputFirstName)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                insertCommand.CommandText = "INSERT INTO Customers VALUES (NULL, @first_Name);";
                insertCommand.Parameters.AddWithValue("@first_Name", inputFirstName);
                insertCommand.ExecuteReader();
                db.Close();
            }
        }
        public static List<String> GetData()
        {
            List<String> entries = new List<string>();
            using (SqliteConnection db =
               new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT first_Name from Customers", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
        }
    }
}
