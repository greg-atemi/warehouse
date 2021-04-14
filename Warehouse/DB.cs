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
			if (!File.Exists("./warehouse_database.sqlite3"))
			{
				SQLiteConnection.CreateFile("warehouse_database.sqlite3");
				System.Console.WriteLine("new database created");
				/*
				 * @Mark I have not yet implemented the logic
				 * to create the schema if no database is found.
				 * But below I have provided the schema for the
				 * 'Client' & 'Cube' tables if you need them(because you need them)^_^
				 */
				
				/*
				 * +++ CLIENT TABLE SCHEMA +++
				 */
				
				// CREATE TABLE "Client" (
				// 	"id"	INTEGER NOT NULL,
				// 	"name"	TEXT NOT NULL,
				// 	"email"	TEXT NOT NULL,
				// 	PRIMARY KEY("id" AUTOINCREMENT)
				// );
				
				
				
				/*
				 * +++ CUBE TABLE SCHEMA +++
				 */
				
				// CREATE TABLE "Cube" (
				// 	"id"	INTEGER NOT NULL,
				// 	"name"	TEXT NOT NULL,
				// 	"occupied"	INTEGER NOT NULL,
				// 	PRIMARY KEY("id" AUTOINCREMENT)
				// );
			}
		}
	}
}