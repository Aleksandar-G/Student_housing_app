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
            FormCreateAppoitment formCreateAppoitment = new FormCreateAppoitment(dtpDate, currentUser, appointmentsForDate);

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

            this.showHouseRules(currentUser.Id);
        }

        public void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            ShowAppointmentsForDate();
            ShowNotificationsFordate();
            // Label label = new Label();
            // label.Text = "Hello";
            // label.Location = new Point(50, 50);
            // Panel panel = new Panel();
            // panel.Controls.Add(label);
            // panel.Height = 100;
            // panel.Width = 100;
            // panel.Visible = true;
            // panel.BackColor = Color.Red;
            // panel.Location = new Point(100, 100);
            // this.tabControl1.TabPages[4].Controls.Add(panel);

            //Appointments appointments = new Appointments();

            //List<string> recentAppoitments= appointments.ShowAppointment();
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

            string dateOfAppointments = dtpShowAppointments.Value.Date.ToShortDateString();


            List<Appointment> recentAppoitments = Appointment.ShowAppointments(dateOfAppointments, User.GetUsersBuildingId(currentUser.Id));
            lbAppoitments.Items.Clear();
            appointmentsForDate.Clear();
            foreach (var item in recentAppoitments)
            {
                appointmentsForDate.Add(item);
                lbAppoitments.Items.Add($"{item.room} from: {item.AppointmentStartDate.ToString("HH:mm")} to:{item.AppointmentEndDate.ToString("HH:mm")}");
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
            AppointmentDetails appointmentDetails = new AppointmentDetails(userIDFromAppointment, startDateOfAppointment, endDateOfAppointment, descriptionAppointment, room);

            appointmentDetails.Show();

            showHouseRules(currentUser.Id);
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

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            if (tbPrice.Text == "")
            {
                MessageBox.Show("Please provide a total price.");
                return;
            }

            if (pbBill.ImageLocation == null)
            {
                MessageBox.Show("Please provide an image.");
                return;
            }

            decimal totalPrice = Convert.ToDecimal(tbPrice.Text);
            Bill bill = new Bill(currentUser.Id, totalPrice, pbBill.ImageLocation);
            bill.InsertIntoDB();
            MessageBox.Show("Split bill request sent successfully!");

            tbPrice.Text = "";
            pbBill.ImageLocation = null;
        }

        private void showHouseRules(int userId)
        {
            tbHouseRules.Text = HouseRule.ShowHouseRules(currentUser.Id);
        }

        public void ShowNotificationsFordate()
        {
            //List<Notification> notificationsForDate = Notification.GetNotificationForDate(DateTime.Today.ToShortDateString());
            List<Notification> notifications = Notification.GetNotificationsByUser(currentUser.Id);

            for (int i = 1; i <= notifications.Count; i++)
            {
                Panel panel = new Panel();
                Label desc = new Label();
                Label title = new Label();
                title.Text = notifications[i - 1].Title;
                title.Location = new Point(10, 10);
                // desc.Text = $ "{notificationForDate}{}" \n {notificationsForDate[i-1].Description}";
                desc.Text = notifications[i - 1].Description;
                desc.Location = new Point(10, 35);
                desc.Width = 300;
                desc.Height = 60;
                panel.Controls.Add(title);
                panel.Controls.Add(desc);
                panel.Height = 100;
                panel.Width = 300;
                panel.Visible = true;
                panel.Location = new Point(250, ((i - 1) * 110) + 30);
                panel.BackColor = Color.LightGray;
                this.tabControl1.TabPages[3].Controls.Add(panel);
            }
        }
    }
}
