using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Warehouse
{
	public class Cube: IDatabase
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public bool Occupied { get; set; }

		public Cube(string name, bool occupied, int id = 0)
		{
			Id = id;
			Name = name;
			Occupied = occupied;
		}
		
		public static List<Cube> GetAll()
		{
			Db myDb = new Db();
			List<Cube> cubes = new List<Cube>();

			myDb.Connection.Open();
			
			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "SELECT * FROM Cube"
			};
			var reader = command.ExecuteReader();
				
			while (reader.Read())
			{
				Cube tempCube;
				tempCube = new Cube(reader.GetString(1), (reader.GetInt32(2) == 1), reader.GetInt32(0));
				cubes.Add(tempCube);
			}
			myDb.Connection.Close();
			return cubes;
		}
		
		public static Cube GetWithId(int id)
		{
			Db myDb = new Db();

			myDb.Connection.Open();
		
			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "SELECT * FROM Cube WHERE id=@id"
			};
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
				
			if (reader.Read())
			{
				var tempCube = new Cube(reader.GetString(1), reader.GetInt32(2) == 1, reader.GetInt32(0));
				myDb.Connection.Close();
				return tempCube;
			}
			myDb.Connection.Close();
			throw new Exception("Cube doesn't not exist");
		}

		public void Save()
		{
			if (Id == 0)
			{
				throw new Exception("Cube does not exist");
			}
			Db myDb = new Db();
			myDb.Connection.Open();
			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "INSERT INTO Cube(name, occupied) VALUES(@name, @occupied)"
			};

			command.Parameters.AddWithValue("@name", Name);
			command.Parameters.AddWithValue("@occupied", Occupied ? 1:0);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row inserted");
			myDb.Connection.Close();
		}

		public void Update()
		{
			if (Id == 0)
			{
				throw new Exception("Cube does not exist");
			}
			Db myDb = new Db();
			myDb.Connection.Open();

			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "UPDATE Cube SET name=@name, occupied=@occupied WHERE id=@id"
			};

			int occupied = Occupied ? 1 : 0;
			command.Parameters.AddWithValue("@name", Name);
			command.Parameters.AddWithValue("@occupied", occupied);
			command.Parameters.AddWithValue("@id", Id);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row updated");
			myDb.Connection.Close();
		}

		public void Delete()
		{
			if (Id == 0)
			{
				throw new Exception("Cube does not exist");
			}
			Db myDb = new Db();
			myDb.Connection.Open();

			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "DELETE FROM Cube WHERE id=@id"
			};
			
			command.Parameters.AddWithValue("@id", Id);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row deleted");
			myDb.Connection.Close();
		}
	}
}