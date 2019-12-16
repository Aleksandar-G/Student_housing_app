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
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.ShowAppointments = new System.Windows.Forms.TabPage();
            this.dtpShowAppointments = new System.Windows.Forms.DateTimePicker();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.btnPrevDate = new System.Windows.Forms.Button();
            this.btnGoCreateAppoitment = new System.Windows.Forms.Button();
            this.lbAppoitments = new System.Windows.Forms.ListBox();
            this.SplitBill = new System.Windows.Forms.TabPage();
            this.CreateComplaint = new System.Windows.Forms.TabPage();
            this.cbBuildingId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitComplaint = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Notifications = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            this.ShowAppointments.SuspendLayout();

            this.CreateComplaint.SuspendLayout();

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

            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);

            this.tabControl1.TabIndexChanged += new System.EventHandler(this.TabControl1_TabIndexChanged);

            // 
            // Login
            // 
            this.Login.Controls.Add(this.btnLogin);
            this.Login.Controls.Add(this.lbPassword);
            this.Login.Controls.Add(this.tbLoginPassword);
            this.Login.Controls.Add(this.lbEmail);
            this.Login.Controls.Add(this.tbLoginEmail);
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
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
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
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(260, 166);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(200, 20);
            this.tbLoginPassword.TabIndex = 2;
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
            // tbLoginEmail
            // 
            this.tbLoginEmail.Location = new System.Drawing.Point(260, 103);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(200, 20);
            this.tbLoginEmail.TabIndex = 0;
            // 
            // ShowAppointments
            // 
            this.ShowAppointments.Controls.Add(this.dtpShowAppointments);
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
            // dtpShowAppointments
            // 
            this.dtpShowAppointments.Location = new System.Drawing.Point(296, 41);
            this.dtpShowAppointments.Name = "dtpShowAppointments";
            this.dtpShowAppointments.Size = new System.Drawing.Size(200, 20);
            this.dtpShowAppointments.TabIndex = 4;
            // 
            // btnNextDate
            // 
            this.btnNextDate.Location = new System.Drawing.Point(513, 41);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(36, 20);
            this.btnNextDate.TabIndex = 3;
            this.btnNextDate.Text = ">";
            this.btnNextDate.UseVisualStyleBackColor = true;
            this.btnNextDate.Click += new System.EventHandler(this.BtnNextDate_Click);
            // 
            // btnPrevDate
            // 
            this.btnPrevDate.Location = new System.Drawing.Point(242, 42);
            this.btnPrevDate.Name = "btnPrevDate";
            this.btnPrevDate.Size = new System.Drawing.Size(32, 20);
            this.btnPrevDate.TabIndex = 2;
            this.btnPrevDate.Text = "<";
            this.btnPrevDate.UseVisualStyleBackColor = true;
            this.btnPrevDate.Click += new System.EventHandler(this.BtnPrevDate_Click);
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
            // lbAppoitments
            // 
            this.lbAppoitments.FormattingEnabled = true;
            this.lbAppoitments.Location = new System.Drawing.Point(219, 108);
            this.lbAppoitments.Name = "lbAppoitments";
            this.lbAppoitments.Size = new System.Drawing.Size(375, 199);
            this.lbAppoitments.TabIndex = 0;
            this.lbAppoitments.DoubleClick += new System.EventHandler(this.LbAppoitments_DoubleClick);
            // 
            // SplitBill
            // 
            this.SplitBill.Location = new System.Drawing.Point(4, 22);
            this.SplitBill.Name = "SplitBill";

            this.SplitBill.Padding = new System.Windows.Forms.Padding(3);

            this.SplitBill.Padding = new System.Windows.Forms.Padding(2);

            this.SplitBill.Size = new System.Drawing.Size(780, 412);
            this.SplitBill.TabIndex = 4;
            this.SplitBill.Text = "Split Bill";
            this.SplitBill.UseVisualStyleBackColor = true;
            // 
            // CreateComplaint
            // 
            this.CreateComplaint.Controls.Add(this.cbBuildingId);
            this.CreateComplaint.Controls.Add(this.label4);
            this.CreateComplaint.Controls.Add(this.btnSubmitComplaint);
            this.CreateComplaint.Controls.Add(this.tbMessage);
            this.CreateComplaint.Controls.Add(this.label3);
            this.CreateComplaint.Controls.Add(this.tbTitle);
            this.CreateComplaint.Controls.Add(this.label2);
            this.CreateComplaint.Controls.Add(this.label1);
            this.CreateComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateComplaint.Location = new System.Drawing.Point(4, 22);
            this.CreateComplaint.Name = "CreateComplaint";
            this.CreateComplaint.Size = new System.Drawing.Size(780, 412);
            this.CreateComplaint.TabIndex = 5;
            this.CreateComplaint.Text = "Create Compaint";
            this.CreateComplaint.UseVisualStyleBackColor = true;
            // 
            // cbBuildingId
            // 
            this.cbBuildingId.FormattingEnabled = true;
            this.cbBuildingId.Location = new System.Drawing.Point(502, 100);
            this.cbBuildingId.Margin = new System.Windows.Forms.Padding(2);
            this.cbBuildingId.Name = "cbBuildingId";
            this.cbBuildingId.Size = new System.Drawing.Size(242, 28);
            this.cbBuildingId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Building:";

    // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitComplaint.Location = new System.Drawing.Point(253, 352);
            this.btnSubmitComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(289, 46);
            this.btnSubmitComplaint.TabIndex = 5;
            this.btnSubmitComplaint.Text = "Submit Complaint";
            this.btnSubmitComplaint.UseVisualStyleBackColor = true;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.BtnSubmitComplaint_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(102, 158);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(643, 187);
            this.tbMessage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(102, 102);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(242, 26);
            this.tbTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Complaint";
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantApp";
            this.Text = "TenantApp";
            this.Load += new System.EventHandler(this.TenantApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();

            this.ShowAppointments.ResumeLayout(false);

            this.CreateComplaint.ResumeLayout(false);
            this.CreateComplaint.PerformLayout();

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.TabPage ShowAppointments;
        private System.Windows.Forms.TabPage SplitBill;
        private System.Windows.Forms.TabPage CreateComplaint;
        private System.Windows.Forms.TabPage Notifications;

        private System.Windows.Forms.DateTimePicker dtpShowAppointments;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.Button btnPrevDate;
        private System.Windows.Forms.Button btnGoCreateAppoitment;
        private System.Windows.Forms.ListBox lbAppoitments;

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitComplaint;
        private System.Windows.Forms.ComboBox cbBuildingId;
        private System.Windows.Forms.Label label4;
    }
}

