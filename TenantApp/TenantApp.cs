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

namespace TenantApp
{
    public partial class TenantApp : Form
    {
        
        public TenantApp()
        {
            InitializeComponent();
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
    }
}
