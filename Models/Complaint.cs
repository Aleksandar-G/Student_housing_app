using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Complaint
    {
        public string title { get; }
        public string description { get; }
        public string buildingAddress { get; }

        private Database db;

        public Complaint(string title, string description, string address)
        {
            this.title = title;
            this.description = description;
            this.buildingAddress = address;
            InsertIntoDB();
        }

        private void InsertIntoDB()
        {
            string query = $"INSERT INTO Complaints(description, buildingId, title) VALUES('{this.description}', (SELECT id FROM Buildings WHERE address = '{this.buildingAddress}'), '{this.title}');";
            this.db = new Database();
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            cmd.ExecuteNonQuery();
            db.Connection.Close();
        }

        public string SelectFromDB()
        {
            return "SELECT * FROM Complaints ORDER BY id ASC";
        }
    }
}
