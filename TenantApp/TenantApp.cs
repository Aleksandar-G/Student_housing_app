using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using MySql.Data.MySqlClient;

namespace TenantApp
{
    public partial class TenantApp : Form
    {
        private Database db = new Database();

        public TenantApp()
        {
            InitializeComponent();
        }
        public void Building_Complaints()
        {
            //cb Fill from DB
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
                cbBuildingId.Items.Add(item);
            }
            dataReader.Close();
            db.Connection.Close();
        }


        private void TenantApp_Load(object sender, EventArgs e)
        {
            Building_Complaints();
        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnSubmitComplaint_Click(object sender, EventArgs e)
        {
            Complaint complaint = new Complaint(tbTitle.Text, tbMessage.Text, cbBuildingId.SelectedItem.ToString());
            complaint.InsertIntoDB();

            MessageBox.Show("Your compaint was sent successfully!");
            this.tbMessage.Text = "";
            this.tbTitle.Text = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = tbLoginEmail.Text;
            string password = tbLoginPassword.Text;

            if (User.Authenticate(email, password))
            {
                MessageBox.Show("Logged in successfully!");
            } else
            {
                MessageBox.Show("Wrong credentials!");
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Filter = "Image Files|*.jpg;*.png";

            openFileDialog1.ShowDialog();

            pbBill.ImageLocation = openFileDialog1.FileName;
        }
    }
}
