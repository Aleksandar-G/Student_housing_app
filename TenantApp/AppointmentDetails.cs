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

            LbUserName.Text ="Author: "+ appointment.SearchForName(this.UserId);
            lbDateTime.Text ="From: "+ this.StartDateTime.ToString("HH:mm");
            lbEndDate.Text ="To: "+ this.EndDateTime.ToString("HH:mm");
            lbDescription.Text = this.Description;
            lbRoom.Text ="Room: "+ Room;
            lbRoom.Left = panel1.Width / 2 - (lbRoom.Width / 2);
            LbUserName.Anchor = AnchorStyles.None;
            LbUserName.Left = panel1.Width / 2 - (LbUserName.Width/2);

        }

        private void LbUserName_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
