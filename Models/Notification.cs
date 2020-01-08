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
        private static int idseeder = 0;
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Notification(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.ID = idseeder;
            idseeder++;
        }
        public static List<Notification> GetNotificationForDate(string date)
        {
            string query = $"SELECT * from Appointments WHERE StartDate = {date}";

            List<Notification> result = new List<Notification>();

            Database database = new Database();

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Notification notification = new Notification("Appointment",dataReader["description"].ToString());

                    result.Add(notification);
                }

                dataReader.Close();

                database.CloseConnection();

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
