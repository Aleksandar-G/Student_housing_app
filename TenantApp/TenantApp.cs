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
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(complaint.QueryInsertIntoDB(), db.Connection);
            cmd.ExecuteNonQuery();
            db.Connection.Close();
            this.tbMessage.Text = "";
            this.tbTitle.Text = "";
        }
    }
}
