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

        private void TenantApp_Load(object sender, EventArgs e)
        {
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
