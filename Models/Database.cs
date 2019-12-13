using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Database
    {
        string server = "remotemysql.com";
        string username = "9puZHPjbEf";
        string password = "NnkepnVWPb";
        string databaseName = "9puZHPjbEf";
        string connectionString = "";
        MySqlConnection connection;
        MySqlDataReader dataReader;

        public MySqlConnection Connection
        {
            get
            {
                return this.connection;
            }
        }
        public MySqlDataReader DataReader { get; set; }

        public Database()
        {
            connectionString = $"Server={server};Database={databaseName};UID={username};Password={password}";

            this.connection = new MySqlConnection(connectionString);
        }
    }
}
