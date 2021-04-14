using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Warehouse
{
	public class Client: IDatabase
	{
		private int _id;
		private string _email, _name;

		public Client()
		{
			_id = 0;
			_name = "";
			_email = "";
		}
		public Client(string name, string email, int id = 0)
		{
			_id = id;
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

		public int Id
		{
			get => _id;
			set => _id = value;
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
				tempClient = new Client(reader.GetString(1), reader.GetString(2), reader.GetInt32(0));
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

		public static Client GetWithId(int id)
		{
			Db myDb = new Db();
			Client tempClient = new Client();
			
			myDb.Connection.Open();
		
			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "SELECT * FROM Client WHERE id=@id"
			};
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
				
			while (reader.Read())
			{
				tempClient.Id = reader.GetInt32(0);
				tempClient.Name = reader.GetString(1);
				tempClient.Email = reader.GetString(2);
			}
			myDb.Connection.Close();
			return tempClient;
		}

		public void Update()
		{
			Db myDb = new Db();
			myDb.Connection.Open();

			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "UPDATE Client SET name=@name, email=@email WHERE id=@id"
			};

			command.Parameters.AddWithValue("@name", _name);
			command.Parameters.AddWithValue("@email", _email);
			command.Parameters.AddWithValue("@id", _id);
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
				CommandText = "DELETE FROM Client WHERE id=@id"
			};
			
			command.Parameters.AddWithValue("@id", _id);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row deleted");
			myDb.Connection.Close();
		}
		
	}
}