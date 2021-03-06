using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iut_dbm_lw4
{
    internal class Hotel : Model
    {
		public static new Dictionary<int, Hotel> Cache = new Dictionary<int, Hotel>();

		public Hotel(int Id, string Title)
		{
			this.Id = Id;
			this.Title = Title;
			TryToCache(this);
		}
		
		public string Title { get; set; }

		public static T GetById<T>(int Id) where T : Hotel
	   {
			return Cache.ContainsKey(Id) ? (T)Cache[Id] : null;
		}

		public static Hotel TryToCache(Hotel model)
		{
			if (!Cache.ContainsKey(model.Id))
			{
				Cache.Add(model.Id, model);
			}
			return Cache[model.Id];
		}

		public static List<string[]> GetCachedLikeString()
        {
			var list = new List<string[]>();
			foreach (var item in Cache.Values)
            {
				list.Add(new string[2] { item.Id.ToString(), item.Title });
            }
			return list;
        }

		public static Dictionary<string, string> GetCachedLikeDict()
		{
			var dict = new Dictionary<string, string>();
			foreach (var item in Cache.Values)
			{
				dict.Add(item.Id.ToString(), item.Title);
			}
			return dict;
		}

		public static void CacheUpdate()
        {
			Cache.Clear();
			CheckConnection();
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "SELECT * FROM hotel;";
				using (MySqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
				{
					while (rd.Read())
					{
						new Hotel(rd.GetInt32(0), rd.GetString(1));
					}
				}
			}
		}

		public static Hotel Create(string Title)
		{
			CheckConnection();

			int Id;
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "INSERT INTO hotel (title) VALUES (@Name);";
				cmd.Parameters.AddWithValue("@Name", Title);
				cmd.ExecuteNonQuery();
				    Id = (int) cmd.LastInsertedId;
			}

			return (Hotel) TryToCache(new Hotel(Id, Title));
		}

		public void Update()
        {
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "UPDATE hotel SET title=@Title WHERE idhotel=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.Parameters.AddWithValue("@Title", Title);
				cmd.ExecuteNonQuery();
			}
		}

		public static void Delete(int Id)
        {
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "DELETE FROM hotel WHERE idhotel=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.ExecuteNonQuery();
			}
		}
	}
}
