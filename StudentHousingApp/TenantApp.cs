using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;

namespace StudentHousingApp
{
    public partial class TenantApp : Form
    {
        AppContext db;
        public TenantApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new AppContext();
            db.Database.Connection.Open();


            User user = new User { Name = "Martin Markov", Address = "Barzaritsa 4a", Email = "martin.markov28@gmail.com", Password = "12345678", Phone = "0887068603", Rent = 330 };
            db.Users.Add(user);
            db.SaveChanges();

            var query = from u in db.Users
                        orderby u.Name
                        select u;

            string passwordHash = BCrypt.Net.BCrypt.HashPassword("my password");

            MessageBox.Show(passwordHash);   
        }

        public bool CheckConnection()
        {
            db = new AppContext();
            try
            {
                db.Database.Connection.Open();
                db.Database.Connection.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Database.Connection.Close();
        }

        private void BtnCreateAppoitment_Click(object sender, EventArgs e)
        {

        }

        private void BtnGoCreateAppoitment_Click(object sender, EventArgs e)
        {
            FormCreateAppoitment formCreateAppoitment = new FormCreateAppoitment();

            formCreateAppoitment.Show();
        }
    }
}
