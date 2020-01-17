using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Newtonsoft.Json;

namespace Models
{
    public class Bill
    {
        int id;
        int buyerId;
        decimal totalPrice;
        string pictureUrl;
        string imageLocation;
        Database db;

        public Bill(int buyerId, decimal totalPrice, string imageLocation)
        {
            this.buyerId = buyerId;
            this.totalPrice = totalPrice;
            this.imageLocation = imageLocation;
        }

        public Bill InsertIntoDB()
        {
            Account account = new Account(
              "matir8",
              "862989996826855",
              "WdCBZBykqX3YJly92X4uO2dUAKk");

            Cloudinary cloudinary = new Cloudinary(account);

            var uploadResult = cloudinary.Upload(new ImageUploadParams()
            {
                File = new FileDescription(@imageLocation)
            });

            this.pictureUrl = uploadResult.Uri.ToString();

            try
            {
                this.db = new Database();
                this.db.Connection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO Bills(buyerId, totalPrice, pictureUrl) VALUES('{buyerId}', '{totalPrice}', '{pictureUrl}');",
                    this.db.Connection
                );
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand($"SELECT DISTINCT * FROM Bills WHERE buyerId = '{buyerId}' AND pictureUrl = '{pictureUrl}'", this.db.Connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                this.id = Convert.ToInt32(dataReader["id"]);
                dataReader.Close();

                Building building = Building.GetBuildingByUser(buyerId);
                List<User> roomates = User.GetUsersByBuilding(building.Id);

                roomates.ForEach(roomate =>
                {
                    MySqlCommand sqlCommand = new MySqlCommand(
                        $"INSERT INTO BillParticipants(userId, billId) VALUES('{roomate.Id}', '{this.id}')", 
                        db.Connection
                    );
                    sqlCommand.ExecuteNonQuery();

                    if (roomate.Id != buyerId)
                    {
                        string billDescription = $"{roomate.Name} has bought groceries for total of €{totalPrice}\r\n{pictureUrl}";
                        Notification notification = new Notification("New Bill added", billDescription, roomate.Id);
                        notification.InsertIntoDB();
                    }
                });
            }
            catch (Exception) { }
            finally
            {
                db.Connection.Close();
            }

            return this;
        }
    }
}
