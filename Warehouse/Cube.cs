using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Warehouse
{
	public class Cube: IDatabase
	{
		private int _id;
		private string _name;
		private bool _occupied;

		public int Id
		{
			get => _id;
			set => _id = value;
		}

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public bool Occupied
		{
			get => _occupied;
			set => _occupied = value;
		}

		public Cube(string name, bool occupied, int id = 0)
		{
			_id = id;
			_name = name;
			_occupied = occupied;
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
			if (_id == 0)
			{
				throw new Exception("Cube does not exist");
			}
			Db myDb = new Db();
			myDb.Connection.Open();
			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "INSERT INTO Cube(name, occupied) VALUES(@name, @occupied)"
			};

			command.Parameters.AddWithValue("@name", _name);
			command.Parameters.AddWithValue("@occupied", _occupied ? 1:0);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row inserted");
			myDb.Connection.Close();
		}

		public void Update()
		{
			if (_id == 0)
			{
				throw new Exception("Cube does not exist");
			}
			Db myDb = new Db();
			myDb.Connection.Open();

			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "UPDATE Cube SET name=@name, occupied=@occupied WHERE id=@id"
			};

			int occupied = _occupied ? 1 : 0;
			command.Parameters.AddWithValue("@name", _name);
			command.Parameters.AddWithValue("@occupied", occupied);
			command.Parameters.AddWithValue("@id", _id);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row updated");
			myDb.Connection.Close();
		}

		public void Delete()
		{
			if (_id == 0)
			{
				throw new Exception("Cube does not exist");
			}
			Db myDb = new Db();
			myDb.Connection.Open();

			var command = new SQLiteCommand(myDb.Connection)
			{
				CommandText = "DELETE FROM Cube WHERE id=@id"
			};
			
			command.Parameters.AddWithValue("@id", _id);
			command.Prepare();

			command.ExecuteNonQuery();

			// Console.WriteLine("row deleted");
			myDb.Connection.Close();
		}
	}
}