using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Models
{
    public class Appointment
    {
        public int id { get;}
        public int UserID { get;}
        public string Description { get;}
        public DateTime AppointmentStartDate { get;}
        public DateTime AppointmentEndDate { get;}
        public string room { get; }
        public int BuildingId { get; private set; }

        public Appointment(int Id, int UserId, string description, DateTime appointmentStartDate,DateTime appointmentEndDate, string room,int buildingId)
        {
            this.id = Id;
            this.UserID = UserId;
            this.Description = description;
            this.AppointmentStartDate = appointmentStartDate;
            this.AppointmentEndDate = appointmentEndDate;
            this.room = room;
            this.BuildingId = buildingId;
        }

        public static void AddAppointment(int userId, string description, string StartDate, string EndDate, string room,int buildingId)
        {
            string query = $"INSERT INTO Appointments (userId,description,StartDate,EndDate,room,buildingId) VALUES('{userId}', '{description}', '{StartDate}', '{EndDate}', '{room}', '{buildingId}' )";
 
            Database database = new Database();
           

            if (database.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                database.CloseConnection();
            }
        }

        public static List<Appointment> ShowAppointments(string StartdateOfappointments,int buildingId)
        {
            string query = $"SELECT * FROM Appointments WHERE StartDate LIKE \'{StartdateOfappointments}%\' AND buildingId = {buildingId} ORDER BY StartDate";

            List<Appointment> result = new List<Appointment>();

            Database database = new Database();

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                                                        
                    Appointment appointment = new Appointment(
                        Convert.ToInt32(dataReader["id"]),
                        Convert.ToInt32(dataReader["userId"]),
                        dataReader["description"].ToString(),
                        Convert.ToDateTime(dataReader["startDate"]),
                        Convert.ToDateTime(dataReader["endDate"]),
                        dataReader["room"].ToString(),
                        Convert.ToInt32(dataReader["buildingId"])
                    ) ;

                    result.Add(appointment);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                database.CloseConnection();

                //return list to be displayed
                return result;
            }
            else
            {
                return null;
            }

        }

        public static string SearchForDescription(int userId, string startDate,string endDate)
        {
            string query = $"SELECT description FROM Appointments WHERE userId = {userId} AND DATE(startDate) = '{startDate}' AND DATE(endDate) = '{endDate}' LIMIT 1";
            
            string description = "";

            Database database = new Database();

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    description = dataReader["description"].ToString();
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                database.CloseConnection();

                return description;

            }
            else
            {
                return "";
            }
        }

        public static string SearchForName(int userId)
        {
            string query = $"SELECT name FROM Users WHERE id = {userId}";
            string name = "";

            Database database = new Database();

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    name = dataReader["name"].ToString();
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                database.CloseConnection();

                return name;
            }
            else
            {
                return null;
            }
        }
    }
}
