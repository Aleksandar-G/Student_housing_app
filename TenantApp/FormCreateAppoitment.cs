using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using Models;

namespace TenantApp
{
    public partial class FormCreateAppoitment : Form
    {
        private User CurrUser;
        private List<Appointment> appointmetsForDate;
        public FormCreateAppoitment(int daysChange,User currUser,List<Appointment> appointmentsForDate)
        {           

            InitializeComponent();

            this.CurrUser = currUser;
            this.appointmetsForDate = appointmentsForDate;
            dtpStartDate.Value = DateTime.Today.AddDays(daysChange);
        }

        private void BtnCreateAppoitment_Click(object sender, EventArgs e)
        {           
            string description = rtbCreateAppoitment.Text;
            if (description == "")
            {
                MessageBox.Show("Please give a desccription for the appointment");
                return;
            }
            string appointmentStartDateTime = dtpStartDate.Value.ToShortDateString() +" " + dtpStartTime.Value.ToString("HH:mm:ss");
            string appointmentEndDateTime = dtpStartDate.Value.ToShortDateString() + " " + dtpEndTime.Value.ToString("HH:mm:ss");
            //string appointmentEndDateTime = appointmentStartDateTime;

            if (Convert.ToDateTime(appointmentStartDateTime) > Convert.ToDateTime(appointmentEndDateTime))
            {
                MessageBox.Show("Please input a correct date of the start and the end of the appointment");
                return;
            }

            string room = "";
            try
            {
                room = cbRooms.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a room for the appointment");
                return;
            }

            List<Appointment> appointments = appointmetsForDate.Select(x => x).Where(x => x.room == room).ToList();

            foreach (var item in appointments)
            {
                if (Convert.ToDateTime(appointmentEndDateTime) >= item.AppointmentStartDate && Convert.ToDateTime(appointmentEndDateTime) <= item.AppointmentEndDate)
                {
                    MessageBox.Show("There is another appointment at that time in that room");
                    return;
                }
                else if (Convert.ToDateTime(appointmentStartDateTime) >= item.AppointmentStartDate && Convert.ToDateTime(appointmentStartDateTime) <= item.AppointmentEndDate)
                {
                    MessageBox.Show("There is another appointment at that time in that room");
                    return;
                }
            }

            Appointment.AddAppointment(CurrUser.Id, description, appointmentStartDateTime, appointmentEndDateTime, room, User.GetUsersBuildingId(CurrUser.Id));

            this.Close();

            if (System.Windows.Forms.Application.OpenForms["TenantApp"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["TenantApp"] as TenantApp).ShowAppointmentsForDate();
            }
        }


        private void FormCreateAppoitment_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.Name);

            ci.DateTimeFormat.ShortDatePattern = "yyyy'-'MM'-'dd";
            ci.DateTimeFormat.LongTimePattern = "hh:mm:ss";

            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}
