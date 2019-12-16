using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Models;
using System.Globalization;
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


        private void BtnCreateAppoitment_Click(object sender, EventArgs e)
        {
            FormCreateAppoitment formCreateAppoitment = new FormCreateAppoitment();

            formCreateAppoitment.Show();

        }
        private void TenantApp_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.Name);

            // ci.DateTimeFormat.ShortDatePattern = "dd'/'MM'/'yyyy";

            ci.DateTimeFormat.ShortDatePattern = "yyyy'-'MM'-'dd";

            ci.DateTimeFormat.LongTimePattern = "hh:mm:ss";

            Thread.CurrentThread.CurrentCulture = ci;

            Thread.CurrentThread.CurrentUICulture = ci;

            Building_Complaints();
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {

            ShowTodaysAppointments();
            //Appointments appointments = new Appointments();

            //List<string> recentAppoitments= appointments.ShowAppointment();
        }

        private void BtnNextDate_Click(object sender, EventArgs e)
        {
            dtpShowAppointments.Value = DateTime.Today.AddDays(+1);
            ShowTodaysAppointments();
        }

        private void BtnPrevDate_Click(object sender, EventArgs e)
        {
            dtpShowAppointments.Value = DateTime.Today.AddDays(-1);
            ShowTodaysAppointments();
        }

        private void ShowTodaysAppointments()
        {
            Appointments appointments = new Appointments();
            string dateOfAppointments = dtpShowAppointments.Value.Date.ToShortDateString();


            List<string> recentAppoitments = appointments.ShowAppointment(dateOfAppointments);
            lbAppoitments.Items.Clear();
            foreach (var item in recentAppoitments)
            {
                lbAppoitments.Items.Add(item);
            }
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
    }
}
