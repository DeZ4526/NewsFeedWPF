using MySqlConnector;
using MySQLDB;
using System;
using System.Collections.Generic;

namespace SNewsLoader.Informator
{
	class MySQLNewsInformator : INewsInformator
	{
		DBConnection dbCon = DBConnection.Instance();
		
		public MySQLNewsInformator(string Server, string DatabaseName, string UserName, string Password)
		{
			dbCon.Server = Server;
			dbCon.DatabaseName = DatabaseName;
			dbCon.UserName = UserName;
			dbCon.Password = Password;
			
		}
		public News[] GetAllNews()
		{
			List<News> result = new List<News>();
			if (dbCon.IsConnect())
			{
				string query = "SELECT Title, Description, LongDescription, ImgUrl, PDate FROM News";
				var cmd = new MySqlCommand(query, dbCon.Connection);
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					string Title = reader.GetString(0);
					string Description = reader.GetString(1);
					string LongDescription = reader.GetString(2);
					string imgUrl = reader.IsDBNull(3) ? "" : reader.GetString(3);
					DateTime Date = reader.GetDateTime(4);
					result.Add(new News(Title,Description,LongDescription, imgUrl, Date));
				}
				dbCon.Close();
			}

			return result.ToArray();
		}

		public News[] GetLastNews(int num)
		{
			throw new NotImplementedException();
		}
	}
}
