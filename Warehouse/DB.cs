using System;
using System.Data.SQLite;
using System.IO;

namespace Warehouse
{
    public class Db
    {
        public SQLiteConnection Connection;

        public Db()
        {
            Connection = new SQLiteConnection("Data Source=warehouse_database.sqlite3");

            if (File.Exists("./warehouse_database.sqlite3")) return;

            SQLiteConnection.CreateFile("warehouse_database.sqlite3");

            Db myDb = new();
            myDb.Connection.Open();

            string[] commandTexts =
            {
                "CREATE TABLE Client (email TEXT NOT NULL PRIMARY KEY, name TEXT NOT NULL);",
                "CREATE TABLE Cube (id	INTEGER NOT NULL PRIMARY KEY, name	TEXT NOT NULL, occupied	INTEGER NOT NULL);",
                "CREATE TABLE Goods (id	INTEGER NOT NULL PRIMARY KEY, name TEXT NOT NULL, description TEXT NOT NULL, client_id	TEXT NOT NULL, cube_id INTEGER NOT NULL, received_date INTEGER NOT NULL, released_date INTEGER, FOREIGN KEY (cube_id) REFERENCES Cube(id) ON UPDATE RESTRICT ON DELETE RESTRICT , FOREIGN KEY (client_id) REFERENCES Client(email) ON UPDATE RESTRICT ON DELETE RESTRICT )"
            };

            foreach (var commandString in commandTexts)
            {
                var command = new SQLiteCommand(myDb.Connection)
                {
                    CommandText = commandString
                };
                command.ExecuteNonQuery();
            }
            
            myDb.Connection.Close();
        }
    }
}