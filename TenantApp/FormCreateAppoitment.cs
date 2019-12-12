﻿using System;
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
        public FormCreateAppoitment()
        {
            InitializeComponent();
        }

        private void BtnCreateAppoitment_Click(object sender, EventArgs e)
        {
             dtpCreateAppoitment.Format = DateTimePickerFormat.Custom;
             dtpCreateAppoitment.CustomFormat = "YYYY-MM-DD hh:mm:ss";

            Appointments appointments = new Appointments();





            string description = rtbCreateAppoitment.Text;
            string appointmentDate = dtpCreateAppoitment.Value.ToString();

            appointments.AddAppointment(13, description, appointmentDate);

            this.Close();
        }

        private void FormCreateAppoitment_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.Name);

            // ci.DateTimeFormat.ShortDatePattern = "dd'/'MM'/'yyyy";

            ci.DateTimeFormat.ShortDatePattern = "yyyy'/'MM'/'dd";

            ci.DateTimeFormat.LongTimePattern = "hh:mm:ss";

            Thread.CurrentThread.CurrentCulture = ci;

            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}
