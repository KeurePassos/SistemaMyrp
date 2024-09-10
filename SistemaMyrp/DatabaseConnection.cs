using System;
using MySql.Data.MySqlClient;

namespace SistemaMyrp
{
	public class DatabaseConnection
	{
		private string connectionString;

		public DatabaseConnection(string server, string database)
		{
			connectionString = $"Server={server};Database={database};User ID=root;Password=#keure123;";
		}

		public MySqlConnection GetConnection()
		{
			return new MySqlConnection(connectionString);
		}

		public void ExecuteQuery(string query)
		{
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var cmd = new MySqlCommand(query, connection))
				{
					cmd.ExecuteNonQuery();
				}
			}
		}

		public MySqlDataReader ExecuteQueryWithResult(string query)
		{
			MySqlConnection connection = GetConnection();
			connection.Open();
			using (var cmd = new MySqlCommand(query, connection))
			{
				return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
			}
		}
	}
}
