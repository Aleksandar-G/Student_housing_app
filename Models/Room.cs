using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Room
    {
        int id;
        int userId;
        int buildingId;
        decimal rent;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Room(int id, int userId, int buildingId, decimal rent)
        {
            this.id = id;
            this.userId = userId;
            this.buildingId = buildingId;
            this.rent = rent;
        }

        public void AssignRoomTo(int userId)
        {
            Database db = new Database();

            try
            {
                db.Connection.Open();
                string query = $"UPDATE BuildingRooms SET userId = {userId} WHERE buildingId = {this.buildingId} AND id = {this.id}";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }
        }

        public static List<Room> GetRooms(int buildingId)
        {
            List<Room> rooms = new List<Room>();
            Database db = new Database();

            try
            {
                db.Connection.Open();
                string query = $"SELECT * FROM BuildingRooms WHERE buildingId = {buildingId}";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader["id"]);
                    int userId = 0;
                    if (dataReader["userId"] != DBNull.Value)
                    {
                        userId = Convert.ToInt32(dataReader["userId"]);
                    }
                    
                    int rent = Convert.ToInt32(dataReader["rent"]);
                    Room room = new Room(id, userId, buildingId, rent);
                    rooms.Add(room);
                }

                dataReader.Close();
            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return rooms;
        }
    }
}
