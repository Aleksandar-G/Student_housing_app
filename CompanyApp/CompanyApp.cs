using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Models;
using MySql.Data.MySqlClient;

namespace CompanyApp
{
    public partial class CompanyApp : Form
    {
        List<Building> buildings;

        public CompanyApp()
        {
            InitializeComponent();
        }
        private void BtnAddTenant_Click(object sender, EventArgs e)
        {
            string name = tbAddTenantName.Text;
            string email = tbAddTenantEmail.Text;
            string password = tbAddTenantPassword.Text;
            string phone = tbAddTenantPhone.Text;
            Building building = buildings.Find(b => b.Address == cbAddTenantAddress.SelectedItem.ToString());
            int roomId = Convert.ToInt32(cbAddTenantRoomNumber.SelectedItem.ToString());

            User tenant = new User(name, email, password, phone);
            tenant.InsertIntoDB();
            Room.GetRooms(building.Id).Find(r => r.Id == roomId).AssignRoomTo(tenant.Id);

            MessageBox.Show("Tenant added successfully!");
        }

        private void CompanyApp_Load(object sender, EventArgs e)
        {
            buildings = new List<Building>(Building.GetBuildings());
            buildings.ForEach(b => {
                cbAddTenantAddress.Items.Add(b.Address);
                cbRemoveTenantAddress.Items.Add(b.Address);
            });
            ShowTenantDetail();
        }

        private void CbAddTenantAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAddTenantRoomNumber.Items.Clear();
            Building selectedBuilding = buildings.Find(b => cbAddTenantAddress.SelectedItem.ToString() == b.Address);
            List<Room> rooms = new List<Room>(Room.GetRooms(selectedBuilding.Id));
            rooms.ForEach(r => cbAddTenantRoomNumber.Items.Add(r.Id));
        }

        private void CbRemoveTenantAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRemoveTenantEmail.Items.Clear();
            Building selectedBuilding = buildings.Find(b => cbRemoveTenantAddress.SelectedItem.ToString() == b.Address);
            List<User> users = new List<User>(User.GetUsersByBuilding(selectedBuilding.Id));
            users.ForEach(u => cbRemoveTenantEmail.Items.Add(u.Email));
        }
        private void BtnRemoveTenant_Click(object sender, EventArgs e)
        {
            Building selectedBuilding = buildings.Find(b => cbRemoveTenantAddress.SelectedItem.ToString() == b.Address);
            List<User> users = new List<User>(User.GetUsersByBuilding(selectedBuilding.Id));
            users.Find(u => cbRemoveTenantEmail.SelectedItem.ToString() == u.Email).DeleteFromDB();
            cbRemoveTenantEmail.Items.RemoveAt(cbRemoveTenantEmail.SelectedIndex);
            cbRemoveTenantEmail.Text = "";
        }
        private void ShowTenantDetail()
        {
            Building_ShowTenantDetails();
        }
        public void Building_ShowTenantDetails()
        {
            //cb Fill from DB

            Database db = new Database();

            db.Connection.Open();
            List<string> result = new List<string>();
            string query = "SELECT address FROM Buildings";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                result.Add(dataReader["address"].ToString());
            }
            foreach (var item in result)
            {
                cbBuildings.Items.Add(item);
            }
            dataReader.Close();
            db.Connection.Close();
        }
        private void CbBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Models.Building.GetBuildingIdByAddress(cbBuildings.SelectedItem.ToString());
            

           List<User>usersInBuilding = User.GetUsersByBuilding(id);

            lbTenants.Items.Clear();
            foreach (var item in usersInBuilding)
            {
                lbTenants.Items.Add(item.Name);
            }
        }
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            string name = lbTenants.SelectedItem.ToString();
            int id = Models.Building.GetBuildingIdByAddress(cbBuildings.SelectedItem.ToString());
            List<User> usersInBuilding = User.GetUsersByBuilding(id);
            User user;
            foreach (var item in usersInBuilding)
            {
                if (item.Name == name)
                {
                    user = item;
                    TenantDetailsForm tenantDetailsForm = new TenantDetailsForm(user);
                    tenantDetailsForm.Show();
                    break;
                }
            }
        }
    }
}
