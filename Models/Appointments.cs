﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Models
{
    public class Appointments
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentStartDate { get; set; }
        public DateTime AppointmentEndDate { get; set; }

        public Appointments()
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.Name);

            // ci.DateTimeFormat.ShortDatePattern = "dd'/'MM'/'yyyy";

            ci.DateTimeFormat.ShortDatePattern = "yyyy'-'MM'-'dd";

            ci.DateTimeFormat.LongTimePattern = "hh:mm:ss";

            Thread.CurrentThread.CurrentCulture = ci;

            Thread.CurrentThread.CurrentUICulture = ci;
        }

        public void AddAppointment(int userId, string description, string StartDate, string EndDate, string room)
        {
            string query = $"INSERT INTO Appointments (userId,description,StartDate,EndDate,room) VALUES('{userId}', '{description}', '{StartDate}', '{EndDate}', '{room}' )";
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

        public List<string> ShowAppointment(string StartdateOfappointments)
        {
            string query = $"SELECT userId,description,StartDate,endDate,room FROM Appointments WHERE StartDate LIKE \'{StartdateOfappointments}%\' ORDER BY StartDate";


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
                    DateTime startDate = Convert.ToDateTime(dataReader["startDate"]);
                    DateTime endDate = Convert.ToDateTime(dataReader["endDate"]);
                    result.Add("UserID: " + dataReader["userId"] + " in "+dataReader["room"]+" " + $"from: { startDate.ToShortDateString()}" + $" ends: {endDate.ToShortDateString()}" );
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

        public string SearchForDescription(int userId, string startDate,string endDate)
        {
            string query = $"SELECT description FROM Appointments WHERE userId = {userId} AND DATE(startDate) = '{startDate}' AND DATE(endDate) = '{endDate}' LIMIT 1";

            string desctiptoon = "";

            Database database = new Database();

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    desctiptoon = dataReader["description"].ToString();
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                database.CloseConnection();

                return desctiptoon;

            }
            else
            {
                return "";
            }
        }

        public string SearchForName(int userId)
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
                    name = dataReader["name"] + "";
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
