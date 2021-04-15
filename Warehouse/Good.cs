using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Warehouse
{
    public class Good : IDatabase
    {
        public Good(string name, string descriptions, DateTime receivedDate, DateTime releasedDate,
            String clientId,
            int cubeId, int id = 0)
        {
            Id = id;
            Name = name;
            Description = descriptions;
            ReceivedDate = receivedDate;
            ReleasedDate = releasedDate;
            ClientId = clientId;
            CubeId = cubeId;
        }

        public int Id { get; set; }

        public DateTime ReceivedDate { get; set; }

        public DateTime ReleasedDate { get; set; }

        public String ClientId { get; set; }

        public int CubeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public static Good GetWithId(int id)
        {
            var myDb = new Db();

            myDb.Connection.Open();

            var command = new SQLiteCommand(myDb.Connection)
            {
                CommandText = "SELECT * FROM Goods WHERE id=@id"
            };
            command.Parameters.AddWithValue("@id", id);
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                var good = new Good(reader.GetString(1), reader.GetString(2),
                    new DateTime(reader.GetInt64(5)),
                    new DateTime(reader.GetInt64(6)), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(0));
                myDb.Connection.Close();
                return good;
            }

            myDb.Connection.Close();
            throw new Exception("No good with that ID");
        }


        public static List<Good> GetAll()
        {
            var myDb = new Db();
            var goods = new List<Good>();

            myDb.Connection.Open();

            var command = new SQLiteCommand(myDb.Connection)
            {
                CommandText = "SELECT * FROM Goods"
            };
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var temp = new Good(reader.GetString(1), reader.GetString(2),
                    new DateTime(reader.GetInt64(5)),
                    new DateTime(reader.GetInt64(6)), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(0));

                goods.Add(temp);
            }

            myDb.Connection.Close();
            return goods;
        }

        public void Save()
        {
            var myDb = new Db();
            myDb.Connection.Open();
            var command = new SQLiteCommand(myDb.Connection)
            {
                CommandText =
                    "INSERT INTO Goods(name, description, client_id, cube_id, received_date, released_date) VALUES(@name, @description, @client_id, @cube_id, @received_date, @released_date)"
            };

            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@description", Description);
            command.Parameters.AddWithValue("@client_id", ClientId);
            command.Parameters.AddWithValue("@cube_id", CubeId);
            command.Parameters.AddWithValue("@received_date", ReceivedDate.Ticks);
            command.Parameters.AddWithValue("@released_date", ReleasedDate.Ticks);
            command.Prepare();

            command.ExecuteNonQuery();

            // Console.WriteLine("row inserted");
            myDb.Connection.Close();
        }

        public void Update()
        {
            var myDb = new Db();
            myDb.Connection.Open();
            var command = new SQLiteCommand(myDb.Connection)
            {
                CommandText =
                    "UPDATE Goods SET name=@name, description=@description, client_id=@client_id, cube_id=@cube_id, received_date=@received_date, released_date=@released_date WHERE id=@id"
            };

            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@description", Description);
            command.Parameters.AddWithValue("@client_id", ClientId);
            command.Parameters.AddWithValue("@cube_id", CubeId);
            command.Parameters.AddWithValue("@received_date", ReceivedDate.Ticks);
            command.Parameters.AddWithValue("@released_date", ReleasedDate.Ticks);
            command.Parameters.AddWithValue("@id", Id);

            command.Prepare();

            command.ExecuteNonQuery();

            myDb.Connection.Close();
        }

        public void Delete()
        {
            var myDb = new Db();
            myDb.Connection.Open();

            var command = new SQLiteCommand(myDb.Connection)
            {
                CommandText = "DELETE FROM Goods WHERE id=@id"
            };

            command.Parameters.AddWithValue("@id", Id);
            command.Prepare();

            command.ExecuteNonQuery();

            myDb.Connection.Close();
        }
    }
}