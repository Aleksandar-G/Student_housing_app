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
        List<Complaint> complaints = new List<Complaint>();
        public CompanyApp()
        {
            InitializeComponent();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                cbHouseRulesAddress.Items.Add(b.Address);
            });

            //Fill Show All Complaints Listbox
            foreach (var item in Complaint.ShowComplaintContent())
            {
                lbShowAllComplaints.Items.Add(item.title + " --- " + item.CreatedAt);
            }

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

        private void BtnShowCurrentComplaint_Click(object sender, EventArgs e)
        {
            if (lbShowAllComplaints.SelectedItem != null)
            {
                Complaint c = Complaint.ShowComplaintContent()[lbShowAllComplaints.SelectedIndex];
                MessageBox.Show(c.description, c.title);
            }
            else
            {
                MessageBox.Show("You have not selected a complaint");
            }
        }

        private void BtnRemoveComplaint_Click(object sender, EventArgs e)
        {
            if (lbShowAllComplaints.SelectedItem != null)
            {
                int del_id = Complaint.ShowComplaintContent()[lbShowAllComplaints.SelectedIndex].Id;
                Complaint.RemoveComplaint(del_id);
                lbShowAllComplaints.Items.Clear();
                foreach (var item in Complaint.ShowComplaintContent())
                {
                    lbShowAllComplaints.Items.Add(item.title + " --- " + item.CreatedAt);
                }
            }
            else
            {
                MessageBox.Show("Please select complaint");
            }
        }
        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            Building selectedBuilding = buildings.Find(b => cbHouseRulesAddress.SelectedItem.ToString() == b.Address);
            int addressId = selectedBuilding.Id;

            HouseRule houseRule = new HouseRule(tbHouseRules.Text, addressId);

            houseRule.AddHouseRuleToDB();
            MessageBox.Show("New house rule(s) was created successfully!");

        }

        private void LbAddTenantName_Click(object sender, EventArgs e)
        {

        }

        private void CbHouseRulesAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHouseRules.Text = HouseRule.GetHouseRules(cbHouseRulesAddress.SelectedItem.ToString());

           
        }
    }
}
