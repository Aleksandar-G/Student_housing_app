using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HouseRule
    {
        public string Rule { get; }
        public int BuildingAddressId { get; }

        private Database db;

        public HouseRule(string rule, int buildingAddressId)
        {
            Rule = rule;
            BuildingAddressId = buildingAddressId;
        }

        public void AddHouseRuleToDB()
        {
            string queryForremoving = $"DELETE FROM HouseRules WHERE buildingId ='{this.BuildingAddressId}';";
            string query = $"INSERT INTO HouseRules(description, buildingId) VALUES('{this.Rule} \r\n', {this.BuildingAddressId});";
            this.db = new Database();
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(queryForremoving, db.Connection);
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand(query, db.Connection);
            cmd2.ExecuteNonQuery();
            db.Connection.Close();
        }

        public string SelectFromDB()
        {
            return "SELECT * FROM HouseRules ORDER BY id ASC";
        }

        public static string ShowHouseRules(int userid)
        {
            int buildingid = User.GetUserBuildingId(userid);
            string query = $"SELECT description FROM HouseRules WHERE buildingId = {buildingid}";

            string houserules = "";
            Database db = new Database();

            try
            {
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    query,
                    db.Connection
                );
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    houserules += dataReader["description"]+'\n'.ToString();
                }
                
                dataReader.Close();

            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return houserules;
        }

        public static string GetHouseRules(string buildingAddress)
        {
            int buildingid = Building.GetBuildingId(buildingAddress);
            string query = $"SELECT description FROM HouseRules WHERE buildingId = {buildingid}";

            string houserules = "";
            Database db = new Database();

            try
            {
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    query,
                    db.Connection
                );
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    houserules += dataReader["description"] + '\n'.ToString();
                }

                dataReader.Close();

            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return houserules;
        }
    }
}
