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

        }
    }
}
