﻿using MySqlConnector;
using System;

namespace MySQLDB
{
	public class DBConnection
	{
		private DBConnection() { }

		public string Server { get; set; }
		public string DatabaseName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

		public MySqlConnection Connection { get; private set; }

		private static DBConnection _instance = null;
		public static DBConnection Instance()
			=> _instance ?? (_instance = new DBConnection());

		public bool IsConnect()
		{
			if (Connection == null)
			{
				if (string.IsNullOrEmpty(DatabaseName))
					return false;
				string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
				Connection = new MySqlConnection(connstring);
				Connection.Open();
			}

			return true;
		}

		public void Close() 
			=> Connection.Close();
	}
}