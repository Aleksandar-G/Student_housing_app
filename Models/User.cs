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

        public int UserId
        {
            get
            {
                return this.userId;
            }
        }
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }
        public string Phone { get; }
        public string PictureUrl { get; }

        public User(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = BCrypt.Net.BCrypt.HashPassword(password);
        }

        public User(string name, string email, string password, string phone)
        {
            this.name = name;
            this.email = email;
            this.password = BCrypt.Net.BCrypt.HashPassword(password);
            this.phone = phone;
        }

        public User(string name, string email, string password, string phone, string pictureUrl)
        {
            this.name = name;
            this.email = email;
            this.password = BCrypt.Net.BCrypt.HashPassword(password);
            this.phone = phone;
            this.pictureUrl = pictureUrl;
        }

        public User InsertIntoDB()
        {
            try
            {
                db = new Database();
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO Users(name, email, password, phone, pictureUrl) VALUES('{name}', '{email}', '{password}', '{phone}', '{pictureUrl}');",
                    db.Connection
                );
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand($"SELECT * FROM Users WHERE name = {name} AND email = {email}", db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                this.userId = Convert.ToInt32(dataReader["id"]);
                
            } catch (Exception) {}
            finally
            {
                db.Connection.Close();
            }

            return this;
        }

        public static bool Authenticate(string email, string password)
        {
            bool result = false;
            Database db = new Database();
            try
            {
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"SELECT * FROM Users WHERE email = '{email}';",
                    db.Connection
                );
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                result = BCrypt.Net.BCrypt.Verify(password, dataReader["password"].ToString());
                dataReader.Close();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.Connection.Close();
            }

            return result;
        }
    }
}
