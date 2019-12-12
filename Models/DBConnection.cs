using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Models
{
    public class DBConnection
    {
        public MySqlConnection con;
        public string connetionString { get; set; }
        public string server { get; set; }
        public string database { get; set; }
        public string username { get; set; }
        public string password { get; set; }


        public DBConnection()
        {
            this.con = new MySqlConnection();
            this.server = "remotemysql.com";
            this.database = "9puZHPjbEf";
            this.username = "9puZHPjbEf";
            this.password = "NnkepnVWPb";
            this.connetionString = "server=" + server + ";database=" + database + ";uid=" + username + ";pwd=" + password + ";";
            con = new MySqlConnection(connetionString);

        }

        public bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
       
    }
}
