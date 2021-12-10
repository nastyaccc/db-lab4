using System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iut_dbm_lw4
{
	internal class Route : Model
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public Hotel Hotel { get; set; }
	     public Carrier Carrier { get; set; }
	     public string RepSurname { get; set; }
	     public string RepName { get; set; }
	     public string RepPhone { get; set; }
	     public int Duration { get; set; }

	     public static new Dictionary<int, Route> Cache = new Dictionary<int, Route>();

		public static T GetById<T>(int Id) where T : Route
		{
			return Cache.ContainsKey(Id) ? (T)Cache[Id] : null;
		}

		public Route(int Id, string Title, string Country, string City, Hotel Hotel, Carrier Carrier, string RepSurname, string RepName, string RepPhone, int Duration)
		{
			this.Id = Id;
			this.Title = Title;
			this.Country = Country;
			this.City = City;
			this.Hotel = Hotel;
			this.Carrier = Carrier;
			this.RepSurname = RepSurname;
			this.RepName = RepName;
			this.RepPhone = RepPhone;
			this.Duration = Duration;
			TryToCache(this);
		}

		public static Route TryToCache(Route model)
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
				list.Add(new string[2] { item.Id.ToString(), String.Format("{0} {1} {2}", item.RepSurname, item.RepName, item.RepPhone) });
			}
			return list;
		}

		public static void CacheUpdate()
		{
			Cache.Clear();
			CheckConnection();
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "SELECT * FROM routes;";
				using (MySqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
				{
					while (rd.Read())
					{
						new Route(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), Hotel.GetById<Hotel>(rd.GetInt32(4)), Carrier.GetById<Carrier>(rd.GetInt32(5)), rd.GetString(6), rd.GetString(7), rd.GetString(8), rd.GetInt32(9));
					}
				}
			}
		}

		public static Route Create(string Title, string Country, string City, Hotel Hotel, Carrier Carrier, string RepSurname, string RepName, string RepPhone, int Duration)
		{
			CheckConnection();

			int Id;
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "INSERT INTO routes (title, country, city, rep_surname, rep_name, rep_phone, duration, idhotel, idcarrier_company) VALUES (@Title, @Country, @City, @RepSurname, @RepName, @RepPhone, @Duration, @HotelId, @CarrierId);";
				cmd.Parameters.AddWithValue("@Title", Title);
				cmd.Parameters.AddWithValue("@Country", Country);
				cmd.Parameters.AddWithValue("@City", City);
				cmd.Parameters.AddWithValue("@RepSurname", RepSurname);
				cmd.Parameters.AddWithValue("@RepName", RepName);
				cmd.Parameters.AddWithValue("@RepPhone", RepPhone);
				cmd.Parameters.AddWithValue("@Duration", Duration);
				if (Hotel != null)
                {
					cmd.Parameters.AddWithValue("@HotelId", Hotel.Id);
				} else
                {
					cmd.Parameters.AddWithValue("@HotelId", null);
				}
				if (Carrier != null)
				{
					cmd.Parameters.AddWithValue("@CarrierId", Carrier.Id);
				}
				else
				{
					cmd.Parameters.AddWithValue("@CarrierId", null);
				}
				cmd.ExecuteNonQuery();
				Id = (int)cmd.LastInsertedId;
			}

			return (Route)TryToCache(new Route(Id, Title, Country, City, Hotel, Carrier, RepSurname, RepName, RepPhone, Duration));
		}

		public void Update()
		{
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "UPDATE routes SET title=@Title, country=@Country, city=@City, idhotel=@HotelId, idcarrier_company=@CarrierId, rep_surname=@RepSurname, rep_name=@RepName, rep_phone=@RepPhone, duration=@Duration WHERE idroutes=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.Parameters.AddWithValue("@Title", Title);
				cmd.Parameters.AddWithValue("@Country", Country);
				cmd.Parameters.AddWithValue("@City", City);
				cmd.Parameters.AddWithValue("@RepSurname", RepSurname);
				cmd.Parameters.AddWithValue("@RepName", RepName);
				cmd.Parameters.AddWithValue("@RepPhone", RepPhone);
				cmd.Parameters.AddWithValue("@Duration", Duration);
				if (Hotel != null)
				{
				    cmd.Parameters.AddWithValue("@HotelId", Hotel.Id);
				}
				else
				{
				    cmd.Parameters.AddWithValue("@HotelId", null);
				}
				if (Carrier != null)
				{
				    cmd.Parameters.AddWithValue("@CarrierId", Carrier.Id);
				}
				else
				{
				    cmd.Parameters.AddWithValue("@CarrierId", null);
				}
				cmd.ExecuteNonQuery();
			}
		}

		public static void Delete(int Id)
		{
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "DELETE FROM routes WHERE idroutes=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.ExecuteNonQuery();
			}
		}
	}
}