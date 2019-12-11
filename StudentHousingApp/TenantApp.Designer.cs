namespace StudentHousingApp
{
    partial class TenantApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.ShowAppointments = new System.Windows.Forms.TabPage();
            this.btnGoCreateAppoitment = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrevDate = new System.Windows.Forms.Button();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CreateAppointment = new System.Windows.Forms.TabPage();
            this.btnCreateAppoitment = new System.Windows.Forms.Button();
            this.rtbDescriptionAppoitment = new System.Windows.Forms.RichTextBox();
            this.dTPickerCreateAppoitment = new System.Windows.Forms.DateTimePicker();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SplitBill = new System.Windows.Forms.TabPage();
            this.CreateComplaint = new System.Windows.Forms.TabPage();
            this.Notifications = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ShowAppointments.SuspendLayout();
            this.CreateAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.ShowAppointments);
            this.tabControl1.Controls.Add(this.CreateAppointment);
            this.tabControl1.Controls.Add(this.SplitBill);
            this.tabControl1.Controls.Add(this.CreateComplaint);
            this.tabControl1.Controls.Add(this.Notifications);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(780, 412);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // ShowAppointments
            // 
            this.ShowAppointments.Controls.Add(this.btnGoCreateAppoitment);
            this.ShowAppointments.Controls.Add(this.listBox1);
            this.ShowAppointments.Controls.Add(this.btnPrevDate);
            this.ShowAppointments.Controls.Add(this.btnNextDate);
            this.ShowAppointments.Controls.Add(this.dateTimePicker1);
            this.ShowAppointments.Location = new System.Drawing.Point(4, 22);
            this.ShowAppointments.Name = "ShowAppointments";
            this.ShowAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.ShowAppointments.Size = new System.Drawing.Size(780, 412);
            this.ShowAppointments.TabIndex = 3;
            this.ShowAppointments.Text = "Show Appointments";
            this.ShowAppointments.UseVisualStyleBackColor = true;
            // 
            // btnGoCreateAppoitment
            // 
            this.btnGoCreateAppoitment.Location = new System.Drawing.Point(323, 354);
            this.btnGoCreateAppoitment.Name = "btnGoCreateAppoitment";
            this.btnGoCreateAppoitment.Size = new System.Drawing.Size(172, 36);
            this.btnGoCreateAppoitment.TabIndex = 4;
            this.btnGoCreateAppoitment.Text = "Create Appoitment";
            this.btnGoCreateAppoitment.UseVisualStyleBackColor = true;
            this.btnGoCreateAppoitment.Click += new System.EventHandler(this.BtnGoCreateAppoitment_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(157, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 225);
            this.listBox1.TabIndex = 3;
            // 
            // btnPrevDate
            // 
            this.btnPrevDate.Location = new System.Drawing.Point(234, 43);
            this.btnPrevDate.Name = "btnPrevDate";
            this.btnPrevDate.Size = new System.Drawing.Size(30, 20);
            this.btnPrevDate.TabIndex = 2;
            this.btnPrevDate.Text = "<";
            this.btnPrevDate.UseVisualStyleBackColor = true;
            // 
            // btnNextDate
            // 
            this.btnNextDate.Location = new System.Drawing.Point(474, 43);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(30, 20);
            this.btnNextDate.TabIndex = 1;
            this.btnNextDate.Text = ">";
            this.btnNextDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // CreateAppointment
            // 
            this.CreateAppointment.Controls.Add(this.btnCreateAppoitment);
            this.CreateAppointment.Controls.Add(this.rtbDescriptionAppoitment);
            this.CreateAppointment.Controls.Add(this.dTPickerCreateAppoitment);
            this.CreateAppointment.Controls.Add(this.tbRoom);
            this.CreateAppointment.Controls.Add(this.label2);
            this.CreateAppointment.Controls.Add(this.label1);
            this.CreateAppointment.Location = new System.Drawing.Point(4, 22);
            this.CreateAppointment.Name = "CreateAppointment";
            this.CreateAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.CreateAppointment.Size = new System.Drawing.Size(780, 412);
            this.CreateAppointment.TabIndex = 1;
            this.CreateAppointment.Text = "Create Appointments";
            this.CreateAppointment.UseVisualStyleBackColor = true;
            // 
            // btnCreateAppoitment
            // 
            this.btnCreateAppoitment.Location = new System.Drawing.Point(362, 363);
            this.btnCreateAppoitment.Name = "btnCreateAppoitment";
            this.btnCreateAppoitment.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAppoitment.TabIndex = 10;
            this.btnCreateAppoitment.Text = "Create";
            this.btnCreateAppoitment.UseVisualStyleBackColor = true;
            this.btnCreateAppoitment.Click += new System.EventHandler(this.BtnCreateAppoitment_Click);
            // 
            // rtbDescriptionAppoitment
            // 
            this.rtbDescriptionAppoitment.Location = new System.Drawing.Point(158, 156);
            this.rtbDescriptionAppoitment.Name = "rtbDescriptionAppoitment";
            this.rtbDescriptionAppoitment.Size = new System.Drawing.Size(466, 178);
            this.rtbDescriptionAppoitment.TabIndex = 9;
            this.rtbDescriptionAppoitment.Text = "";
            // 
            // dTPickerCreateAppoitment
            // 
            this.dTPickerCreateAppoitment.Location = new System.Drawing.Point(288, 40);
            this.dTPickerCreateAppoitment.Name = "dTPickerCreateAppoitment";
            this.dTPickerCreateAppoitment.Size = new System.Drawing.Size(200, 20);
            this.dTPickerCreateAppoitment.TabIndex = 8;
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(288, 89);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(100, 20);
            this.tbRoom.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pick a room:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick a date:";
            // 
            // SplitBill
            // 
            this.SplitBill.Location = new System.Drawing.Point(4, 22);
            this.SplitBill.Name = "SplitBill";
            this.SplitBill.Padding = new System.Windows.Forms.Padding(3);
            this.SplitBill.Size = new System.Drawing.Size(780, 412);
            this.SplitBill.TabIndex = 4;
            this.SplitBill.Text = "Split Bill";
            this.SplitBill.UseVisualStyleBackColor = true;
            // 
            // CreateComplaint
            // 
            this.CreateComplaint.Location = new System.Drawing.Point(4, 22);
            this.CreateComplaint.Name = "CreateComplaint";
            this.CreateComplaint.Size = new System.Drawing.Size(780, 412);
            this.CreateComplaint.TabIndex = 5;
            this.CreateComplaint.Text = "Create Compaint";
            this.CreateComplaint.UseVisualStyleBackColor = true;
            // 
            // Notifications
            // 
            this.Notifications.Location = new System.Drawing.Point(4, 22);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(780, 412);
            this.Notifications.TabIndex = 6;
            this.Notifications.Text = "Notifications";
            this.Notifications.UseVisualStyleBackColor = true;
            // 
            // TenantApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantApp";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ShowAppointments.ResumeLayout(false);
            this.CreateAppointment.ResumeLayout(false);
            this.CreateAppointment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage ShowAppointments;
        private System.Windows.Forms.TabPage CreateAppointment;
        private System.Windows.Forms.TabPage SplitBill;
        private System.Windows.Forms.TabPage CreateComplaint;
        private System.Windows.Forms.TabPage Notifications;
        private System.Windows.Forms.Button btnGoCreateAppoitment;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrevDate;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCreateAppoitment;
        private System.Windows.Forms.RichTextBox rtbDescriptionAppoitment;
        private System.Windows.Forms.DateTimePicker dTPickerCreateAppoitment;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

