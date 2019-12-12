using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Appointments
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Appointments()
        {

        }

        public void AddAppointment(int userId,string description, string appointmentDate)
        {
            string query = $"INSERT INTO Appointments (userId,description,appointmentDate) VALUES('{userId}', '{description}', '{appointmentDate}')";
            //DBConnection con = new DBConnection();
            Database database = new Database();
            //if (con.OpenConnection() == true)
            //{
            //    //create command and assign the query and connection from the constructor
            //    MySqlCommand cmd = new MySqlCommand(query, con.con);

            //    //Execute command
            //    cmd.ExecuteNonQuery();

            //    //close connection
            //    con.CloseConnection();
            //}

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

        public List<string> ShowAppointment(string dateOfappointments)
        {
            string query = $"SELECT userId,appointmentDate FROM Appointments WHERE appointmentDate LIKE \'{dateOfappointments}%\' ORDER BY appointmentDate";


            List<string> result = new List<string>();

            //DBConnection con = new DBConnection();

            Database database = new Database();

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    result.Add("UserID: " + dataReader["userId"] + " Date of the appointmnet " + dataReader["appointmentDate"]+ "");
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
    }
}
