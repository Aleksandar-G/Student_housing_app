using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int UserId { get; private set; }

        public Notification(string title, string description, int userId)
        {
            this.Title = title;
            this.Description = description;
            this.UserId = userId;
        }

        public void InsertIntoDB()
        {
            Database db = new Database();
            string query = $"INSERT INTO Notifications(title, description, userId) VALUES('{this.Title}', '{this.Description}', {this.UserId});";
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            cmd.ExecuteNonQuery();
            db.Connection.Close();
        }

        public static List<Notification> GetNotificationsByUser(int userId)
        {
            Database db = new Database();
            List<Notification> notifications = new List<Notification>();
            string query = $"SELECT * FROM Notifications WHERE userId = {userId};";
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string title = dataReader["title"].ToString();
                string description = dataReader["description"].ToString();
                notifications.Add(new Notification(title, description, userId));
            }

            db.Connection.Close();
            return notifications;
        }

        //public static List<Notification> GetNotificationForDate(string date)
        //{
        //    string query = $"SELECT * from Appointments WHERE date(startDate) LIKE '{date}';";

        //    List<Notification> result = new List<Notification>();

        //    Database database = new Database();

        //    if (database.OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, database.Connection);
        //        //Create a data reader and Execute the command
        //        MySqlDataReader dataReader = cmd.ExecuteReader();

        //        while (dataReader.Read())
        //        {
        //            Notification notification = new Notification("Appointment",dataReader["description"].ToString(), user);

        //            result.Add(notification);
        //        }

        //        dataReader.Close();

        //        database.CloseConnection();

        //        return result;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
