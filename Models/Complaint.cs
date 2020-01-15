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
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }

        private Database db;

        public Complaint(string title, string description, string address)
        {
            this.title = title;
            this.description = description;
            this.buildingAddress = address;
        }

        public void InsertIntoDB()
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
            return "SELECT * FROM Complaints ORDER BY id DESC";
            //TEST
        }
        public static void RemoveComplaint(int id)
        {
            string query = $"DELETE FROM Complaints WHERE id = {id}";
            Database localdb = new Database();
            localdb.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, localdb.Connection);
            cmd.ExecuteNonQuery();
            localdb.Connection.Close();

        }
        public static List<Complaint> ShowComplaintContent()
        {
            Database localdb = new Database();
            localdb.Connection.Open();
            string query = "SELECT * FROM Complaints";
            List<Complaint> resultToShow = new List<Complaint>();
            MySqlCommand cmd = new MySqlCommand(query, localdb.Connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Complaint c = new Complaint(dataReader["title"].ToString(), dataReader["description"].ToString(), dataReader["buildingId"].ToString());
                c.Id = Convert.ToInt32(dataReader["id"]);
                c.CreatedAt = Convert.ToDateTime(dataReader["createdAt"]);
                resultToShow.Add(c);
            }
            return resultToShow;
        }
        
    }
}
