using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        private int userId;
        private string name;
        private string email;
        private string password;
        private string phone;
        private string pictureUrl;
        private Database db;

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string PictureUrl { get; set; }

        public User(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            InsertIntoDB();
        }

        public User(string name, string email, string password, string phone)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
            InsertIntoDB();
        }

        public User(string name, string email, string password, string phone, string pictureUrl)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.pictureUrl = pictureUrl;
            InsertIntoDB();
        }

        private bool InsertIntoDB()
        {
            bool result;

            try
            {
                db = new Database();
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO Users(name, email, password, phone, pictureUrl) VALUES('{name}', '{email}', '{password}', '{phone}', '{pictureUrl}');",
                    db.Connection
                );
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception)
            {
                result = false;
            }
            finally
            {
                db.Connection.Close();
            }

            return result;
        }
    }
}
