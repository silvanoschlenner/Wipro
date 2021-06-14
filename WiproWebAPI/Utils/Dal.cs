using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;

namespace WiproWebAPI.Utils
{
    public class Dal
    {
		private static string Server = "localhost";
		private static string Database = "wipro";
		private static string User = "root";
		private static string Password = "Silva3465";

		private MySqlConnection Connection;

		private string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;charset=utf8;";
		public Dal()    // Construtor da classe
		{
			Connection = new MySqlConnection(ConnectionString);
			Connection.Open();
		}

		// Executa: INSERT, UPDATE e DELETE
		public void ExecutarComandoSQL(string sql)
		{
			MySqlCommand Command = new MySqlCommand(sql, Connection);
			Command.ExecuteNonQuery();
		}

		// Retorna dados do Banco
		public DataTable RetornarDataTable(string sql)
		{
			MySqlCommand Command = new MySqlCommand(sql, Connection);
			MySqlDataAdapter DataAdapter = new MySqlDataAdapter(Command);
			DataTable Dados = new DataTable();
			DataAdapter.Fill(Dados);
			return Dados;
		}
	}
}
