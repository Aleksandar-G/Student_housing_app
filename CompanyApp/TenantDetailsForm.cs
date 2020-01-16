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

namespace CompanyApp
{
    public partial class TenantDetailsForm : Form
    {
        public TenantDetailsForm(User user)
        {
            InitializeComponent();

            lbname.Text = "Name: " + user.Name;
            lbemail.Text ="Email: "+ user.Email;
            lbphone.Text ="Phone: "+ user.Phone;
            lbaddress.Text ="Address: "+ User.GetUserAddress(user.Id);
            lbroom.Text ="Room ID: "+ User.GetUserRoom(user.Id).ToString();
            lbRoomRent.Text = "Rent: " + User.GetUserRoomRent(user.Id).ToString();
        }
    }
}
