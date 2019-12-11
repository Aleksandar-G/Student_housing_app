namespace TenantApp
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowAppointments = new System.Windows.Forms.TabPage();
            this.SplitBill = new System.Windows.Forms.TabPage();
            this.CreateComplaint = new System.Windows.Forms.TabPage();
            this.Notifications = new System.Windows.Forms.TabPage();
            this.lbAppoitments = new System.Windows.Forms.ListBox();
            this.btnGoCreateAppoitment = new System.Windows.Forms.Button();
            this.btnPrevDate = new System.Windows.Forms.Button();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            this.ShowAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.ShowAppointments);
            this.tabControl1.Controls.Add(this.SplitBill);
            this.tabControl1.Controls.Add(this.CreateComplaint);
            this.tabControl1.Controls.Add(this.Notifications);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.btnLogin);
            this.Login.Controls.Add(this.lbPassword);
            this.Login.Controls.Add(this.textBox2);
            this.Login.Controls.Add(this.lbEmail);
            this.Login.Controls.Add(this.textBox1);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(780, 412);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(260, 221);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(332, 150);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(343, 87);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ShowAppointments
            // 
            this.ShowAppointments.Controls.Add(this.dateTimePicker1);
            this.ShowAppointments.Controls.Add(this.btnNextDate);
            this.ShowAppointments.Controls.Add(this.btnPrevDate);
            this.ShowAppointments.Controls.Add(this.btnGoCreateAppoitment);
            this.ShowAppointments.Controls.Add(this.lbAppoitments);
            this.ShowAppointments.Location = new System.Drawing.Point(4, 22);
            this.ShowAppointments.Name = "ShowAppointments";
            this.ShowAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.ShowAppointments.Size = new System.Drawing.Size(780, 412);
            this.ShowAppointments.TabIndex = 3;
            this.ShowAppointments.Text = "Show Appointments";
            this.ShowAppointments.UseVisualStyleBackColor = true;
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
            // lbAppoitments
            // 
            this.lbAppoitments.FormattingEnabled = true;
            this.lbAppoitments.Location = new System.Drawing.Point(219, 108);
            this.lbAppoitments.Name = "lbAppoitments";
            this.lbAppoitments.Size = new System.Drawing.Size(375, 199);
            this.lbAppoitments.TabIndex = 0;
            // 
            // btnGoCreateAppoitment
            // 
            this.btnGoCreateAppoitment.Location = new System.Drawing.Point(329, 347);
            this.btnGoCreateAppoitment.Name = "btnGoCreateAppoitment";
            this.btnGoCreateAppoitment.Size = new System.Drawing.Size(167, 40);
            this.btnGoCreateAppoitment.TabIndex = 1;
            this.btnGoCreateAppoitment.Text = "Create Appointment";
            this.btnGoCreateAppoitment.UseVisualStyleBackColor = true;
            this.btnGoCreateAppoitment.Click += new System.EventHandler(this.BtnCreateAppoitment_Click);
            // 
            // btnPrevDate
            // 
            this.btnPrevDate.Location = new System.Drawing.Point(242, 42);
            this.btnPrevDate.Name = "btnPrevDate";
            this.btnPrevDate.Size = new System.Drawing.Size(32, 20);
            this.btnPrevDate.TabIndex = 2;
            this.btnPrevDate.Text = "<";
            this.btnPrevDate.UseVisualStyleBackColor = true;
            // 
            // btnNextDate
            // 
            this.btnNextDate.Location = new System.Drawing.Point(513, 41);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(36, 20);
            this.btnNextDate.TabIndex = 3;
            this.btnNextDate.Text = ">";
            this.btnNextDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // TenantApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantApp";
            this.Text = "TenantApp";
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ShowAppointments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage ShowAppointments;
        private System.Windows.Forms.TabPage SplitBill;
        private System.Windows.Forms.TabPage CreateComplaint;
        private System.Windows.Forms.TabPage Notifications;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.Button btnPrevDate;
        private System.Windows.Forms.Button btnGoCreateAppoitment;
        private System.Windows.Forms.ListBox lbAppoitments;
    }
}

