using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Warehouse
{
	public class Client: IDatabase
	{
		private string _email, _name;
		
		public Client(string name, string email)
		{
			_name = name;
			_email = email;
		}

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public string Email
		{
			get => _email;
			set => _email = value;
		}

		public static List<Client> GetAll()
		{
			Db myDb = new Db();
			List<Client> clients = new List<Client>();

			myDb.Connection.Open();
			
			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "SELECT * FROM Client"
			};
			var reader = command.ExecuteReader();
				
			while (reader.Read())
			{
				Client tempClient;
				tempClient = new Client(reader.GetString(1), reader.GetString(0));
				clients.Add(tempClient);
			}
			myDb.Connection.Close();
			return clients;
		}

		public void Save()
		{
			Db myDb = new Db();
			myDb.Connection.Open();
			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "INSERT INTO Client(name, email) VALUES(@name, @email)"
			};

			command.Parameters.AddWithValue("@name", _name);
			command.Parameters.AddWithValue("@email", _email);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row inserted");
			myDb.Connection.Close();
		}

		public static Client GetWithEmail(string email)
		{
			Db myDb = new Db();
			
			myDb.Connection.Open();
			
			using var command = new SQLiteCommand(myDb.Connection);
			command.CommandText = "SELECT * FROM Client WHERE email=@email";
			command.Parameters.AddWithValue("@email", email);

			using (var reader = command.ExecuteReader())
			{
				if (reader.Read())
				{
					var tempClient = new Client(reader.GetString(1), reader.GetString(0));
					myDb.Connection.Close();
					return tempClient;
				}

				myDb.Connection.Close();
				throw new Exception("client id not found.");
			}
		}

		public void Update()
		{
			Db myDb = new Db();
			myDb.Connection.Open();

			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "UPDATE Client SET name=@name, email=@email WHERE email=@email"
			};

			command.Parameters.AddWithValue("@name", _name);
			command.Parameters.AddWithValue("@email", _email);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row updated");
			myDb.Connection.Close();
		}

		public void Delete()
		{
			Db myDb = new Db();
			myDb.Connection.Open();

			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "DELETE FROM Client WHERE email=@email"
			};
			
			command.Parameters.AddWithValue("@email", _email);
			// command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row deleted");
			myDb.Connection.Close();
		}
		
	}
}