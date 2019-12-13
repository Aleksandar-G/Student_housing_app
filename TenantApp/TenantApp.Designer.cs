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
            this.CreateAppointment = new System.Windows.Forms.TabPage();
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
            this.CreateComplaint.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(8, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 539);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.TabControl1_TabIndexChanged);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.btnLogin);
            this.Login.Controls.Add(this.lbPassword);
            this.Login.Controls.Add(this.textBox2);
            this.Login.Controls.Add(this.lbEmail);
            this.Login.Controls.Add(this.textBox1);
            this.Login.Location = new System.Drawing.Point(4, 25);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(4);
            this.Login.Size = new System.Drawing.Size(1043, 510);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(347, 272);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(267, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(443, 185);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(69, 17);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 204);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 22);
            this.textBox2.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(457, 107);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 127);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 0;
            // 
            // ShowAppointments
            // 
            this.ShowAppointments.Location = new System.Drawing.Point(4, 25);
            this.ShowAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.ShowAppointments.Name = "ShowAppointments";
            this.ShowAppointments.Padding = new System.Windows.Forms.Padding(4);
            this.ShowAppointments.Size = new System.Drawing.Size(1043, 510);
            this.ShowAppointments.TabIndex = 3;
            this.ShowAppointments.Text = "Show Appointments";
            this.ShowAppointments.UseVisualStyleBackColor = true;
            // 
            // CreateAppointment
            // 
            this.CreateAppointment.Location = new System.Drawing.Point(4, 25);
            this.CreateAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.CreateAppointment.Name = "CreateAppointment";
            this.CreateAppointment.Padding = new System.Windows.Forms.Padding(4);
            this.CreateAppointment.Size = new System.Drawing.Size(1043, 510);
            this.CreateAppointment.TabIndex = 1;
            this.CreateAppointment.Text = "Create Appointments";
            this.CreateAppointment.UseVisualStyleBackColor = true;
            // 
            // SplitBill
            // 
            this.SplitBill.Location = new System.Drawing.Point(4, 25);
            this.SplitBill.Margin = new System.Windows.Forms.Padding(4);
            this.SplitBill.Name = "SplitBill";
            this.SplitBill.Padding = new System.Windows.Forms.Padding(3);
            this.SplitBill.Size = new System.Drawing.Size(1043, 510);
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
            this.CreateComplaint.Location = new System.Drawing.Point(4, 25);
            this.CreateComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.CreateComplaint.Name = "CreateComplaint";
            this.CreateComplaint.Size = new System.Drawing.Size(1043, 510);
            this.CreateComplaint.TabIndex = 5;
            this.CreateComplaint.Text = "Create Compaint";
            this.CreateComplaint.UseVisualStyleBackColor = true;
            // 
            // cbBuildingId
            // 
            this.cbBuildingId.FormattingEnabled = true;
            this.cbBuildingId.Location = new System.Drawing.Point(670, 123);
            this.cbBuildingId.Name = "cbBuildingId";
            this.cbBuildingId.Size = new System.Drawing.Size(322, 33);
            this.cbBuildingId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buiilding number:";
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitComplaint.Location = new System.Drawing.Point(337, 433);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(385, 56);
            this.btnSubmitComplaint.TabIndex = 5;
            this.btnSubmitComplaint.Text = "Submit Complaint";
            this.btnSubmitComplaint.UseVisualStyleBackColor = true;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.BtnSubmitComplaint_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(136, 195);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(856, 229);
            this.tbMessage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(136, 126);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(322, 30);
            this.tbTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Complaint";
            // 
            // Notifications
            // 
            this.Notifications.Location = new System.Drawing.Point(4, 25);
            this.Notifications.Margin = new System.Windows.Forms.Padding(4);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(1043, 510);
            this.Notifications.TabIndex = 6;
            this.Notifications.Text = "Notifications";
            this.Notifications.UseVisualStyleBackColor = true;
            // 
            // TenantApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TenantApp";
            this.Text = "TenantApp";
            this.Load += new System.EventHandler(this.TenantApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.CreateComplaint.ResumeLayout(false);
            this.CreateComplaint.PerformLayout();
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
        private System.Windows.Forms.TabPage CreateAppointment;
        private System.Windows.Forms.TabPage SplitBill;
        private System.Windows.Forms.TabPage CreateComplaint;
        private System.Windows.Forms.TabPage Notifications;
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

