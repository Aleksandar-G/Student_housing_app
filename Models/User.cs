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
        private int id;
        private string name;
        private string email;
        private string password;
        private string phone;
        private string pictureUrl;
        private Database db;

        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
        }
        public string PictureUrl
        {
            get
            {
                return this.pictureUrl;
            }
        }

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

        public User(int id, string name, string email, string password, string phone, string pictureUrl)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = BCrypt.Net.BCrypt.HashPassword(password);
            this.phone = phone;
            this.pictureUrl = pictureUrl;
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

                cmd = new MySqlCommand($"SELECT * FROM Users WHERE name = '{name}' AND email = '{email}'", db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                this.id = Convert.ToInt32(dataReader["id"]);

            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return this;
        }

        public void DeleteFromDB()
        {
            try
            {
                db = new Database();
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"UPDATE BuildingRooms SET userId = null WHERE userId = {this.id}",
                    db.Connection
                );
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand($"DELETE FROM Users WHERE id = {this.id};", db.Connection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.Connection.Close();
            }

            return result;
        }

        public static User GetUserByEmail(string email)
        {
            Database db = new Database();
            User user = null;

            try
            {
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"SELECT * FROM Users WHERE email = '{email}';",
                    db.Connection
                );
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                user = new User(
                    Convert.ToInt32(dataReader["id"]),
                    dataReader["name"].ToString(),
                    dataReader["email"].ToString(),
                    dataReader["password"].ToString(),
                    dataReader["phone"].ToString(),
                    dataReader["pictureUrl"].ToString()
                );
                dataReader.Close();

            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return user;
        }

        public static List<User> GetUsersByBuilding(int buildingId)
        {
            List<User> users = new List<User>();
            Database db = new Database();

            try
            {
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"SELECT * FROM Users u INNER JOIN BuildingRooms br ON u.id = br.userId WHERE br.buildingId = {buildingId};",
                    db.Connection
                );
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    users.Add(new User(Convert.ToInt32(dataReader["userId"]),
                                       dataReader["name"].ToString(),
                                       dataReader["email"].ToString(),
                                       dataReader["password"].ToString(),
                                       dataReader["phone"].ToString(),
                                       dataReader["pictureUrl"].ToString()));
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.Connection.Close();
            }

            return users;
        }

        public static string GetUserAddress(int userid)
        {
            string query = $"select address from Buildings WHERE id = (SELECT buildingId FROM BuildingRooms WHERE userid = {userid}); ";

            string address = "";

            Database db = new Database();

            try
            {
                db.Connection.Open();
                
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    address = dataReader["address"].ToString();
                }

                dataReader.Close();
            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return address;
        }

        public static int GetUserRoom(int userId)
        {
            string query = $"SELECT id FROM BuildingRooms  WHERE userid  = {userId};";

            string roomid = "";

            Database db = new Database();

            try
            {
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    roomid = dataReader["id"].ToString();
                }

                dataReader.Close();
            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return Convert.ToInt32(roomid);
        }
        public static int GetUsersBuildingId(int userId)
        {
            string query = $"SELECT buildingId FROM BuildingRooms AS br inner join Users as u on br.userId = u.id WHERE userid = {userId};";

            int userBuildingId = 0;

            Database database = new Database();

            if (database.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, database.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    userBuildingId =Convert.ToInt32(dataReader["buildingId"]);
                }

                dataReader.Close();

                database.CloseConnection();

                return userBuildingId;
            }
            else
            {
                return 0;
            }
        }
    }
}
