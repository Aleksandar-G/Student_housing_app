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

namespace TenantApp
{
    public partial class AppointmentDetails : Form
    {
        int UserId;
        DateTime StartDateTime;
        DateTime EndDateTime;
        string Description;
        string Room;
        public AppointmentDetails(int userId, DateTime StartdateTime,DateTime endDatetime,  string description, string room)
        {
            InitializeComponent();

            this.UserId = userId;
            this.StartDateTime = StartdateTime;
            this.EndDateTime = endDatetime;
            this.EndDateTime = endDatetime;
            this.Description = description;
            this.Room = room;

            Appointment appointment = new Appointment();

            LbUserName.Text = appointment.SearchForName(this.UserId);
            lbDateTime.Text = this.StartDateTime.ToString("HH:mm");
            lbEndDate.Text = this.EndDateTime.ToString("HH:mm");
            lbDescription.Text = this.Description;
            lbRoom.Text = Room;

        }

        private void LbUserName_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
