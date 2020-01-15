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

        int dtpDate = 0;
        List<Appointment> appointmentsForDate = new List<Appointment>();
        
        private User currentUser;

        public TenantApp(User user)
        {
            InitializeComponent();
            this.currentUser = user;
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
            FormCreateAppoitment formCreateAppoitment = new FormCreateAppoitment(dtpDate,currentUser, appointmentsForDate);

            formCreateAppoitment.Show();

        }
        private void TenantApp_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.Name);


            ci.DateTimeFormat.ShortDatePattern = "yyyy'-'MM'-'dd";

            ci.DateTimeFormat.LongTimePattern = "hh:mm:ss";

            Thread.CurrentThread.CurrentCulture = ci;

            Thread.CurrentThread.CurrentUICulture = ci;

            Building_Complaints();
            ShowAppointmentsForDate();
        }

        public void TabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void BtnNextDate_Click(object sender, EventArgs e)
        {
            dtpDate++;

            dtpShowAppointments.Value = DateTime.Today.AddDays(dtpDate);
            ShowAppointmentsForDate();
            
        }

        private void BtnPrevDate_Click(object sender, EventArgs e)
        {
            dtpDate--;

            dtpShowAppointments.Value = DateTime.Today.AddDays(dtpDate);
            ShowAppointmentsForDate();

        }

        public void ShowAppointmentsForDate()
        {
            
            Appointment appointments = new Appointment();
            string dateOfAppointments = dtpShowAppointments.Value.Date.ToShortDateString();
           

            List<Appointment> recentAppoitments = appointments.ShowAppointments(dateOfAppointments,User.GetUsersBuildingId(currentUser.Id));
            lbAppoitments.Items.Clear();
            appointmentsForDate.Clear();
            foreach (var item in recentAppoitments)
            {
                appointmentsForDate.Add(item);
                lbAppoitments.Items.Add($"{item.room} from: {item.AppointmentStartDate.ToString("HH:mm")} to:{item.AppointmentEndDate.ToString("HH:mm")}" );
            }
        }

        private void LbAppoitments_DoubleClick(object sender, EventArgs e)
        {
            

            Appointment selectedAppointment = appointmentsForDate[lbAppoitments.SelectedIndex];

            
             int userIDFromAppointment = Convert.ToInt32(selectedAppointment.UserID);
             DateTime startDateOfAppointment = selectedAppointment.AppointmentStartDate;
             DateTime endDateOfAppointment = selectedAppointment.AppointmentEndDate;
            string descriptionAppointment = selectedAppointment.Description;
            string room = selectedAppointment.room;
            AppointmentDetails appointmentDetails = new AppointmentDetails(userIDFromAppointment, startDateOfAppointment, endDateOfAppointment, descriptionAppointment,room);

            appointmentDetails.Show();
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
