﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Building
    {
        private string address;
        private int id;
        private Database db;

        public string Address
        {
            get
            {
                return this.address;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public Building(int id, string address)
        {
            this.id = id;
            this.address = address;
        }

        public bool InsertIntoDB()
        {
            bool result;

            try
            {
                db = new Database();
                db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO Buildings(address) VALUES('{this.address}');",
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

        public static List<Building> GetBuildings()
        {
            List<Building> buildings = new List<Building>();
            Database db = new Database();

            try
            {
                db.Connection.Open();
                string query = "SELECT * FROM Buildings";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int buildingId = Convert.ToInt32(dataReader["id"]);
                    string buildingAddress = dataReader["address"].ToString();
                    Building building = new Building(buildingId, buildingAddress);
                    buildings.Add(building);
                }

                dataReader.Close();
            }
            catch(Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return buildings;
        }
    }
}