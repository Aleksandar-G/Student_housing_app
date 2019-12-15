using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Models;

namespace CompanyApp
{
    public partial class CompanyApp : Form
    {
        public CompanyApp()
        {
            InitializeComponent();
        }
        List<Building> buildings;

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
            Room.GetRooms(building.Id).Find(r => r.Id == roomId).AssignRoomTo(tenant.UserId);

            MessageBox.Show("Tenant added successfully!");
        }

        private void CompanyApp_Load(object sender, EventArgs e)
        {
            buildings = new List<Building>(Building.GetBuildings());
            buildings.ForEach(b => cbAddTenantAddress.Items.Add(b.Address));
        }

        private void CbAddTenantAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            Building selectedBuilding = buildings.Find(b => cbAddTenantAddress.SelectedItem.ToString() == b.Address);
            List<Room> rooms = new List<Room>(Room.GetRooms(selectedBuilding.Id));
            rooms.ForEach(r => cbAddTenantRoomNumber.Items.Add(r.Id));
        }
    }
}
