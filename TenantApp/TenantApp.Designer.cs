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
            //this.btnSplit = new System.Windows.Forms.Button();
            //this.pbBill = new System.Windows.Forms.PictureBox();
            //this.btnBrowse = new System.Windows.Forms.Button();
            //this.textBox3 = new System.Windows.Forms.TextBox();
            //this.lblPicture = new System.Windows.Forms.Label();
            //this.lblPrice = new System.Windows.Forms.Label();
            //this.lblGroceries = new System.Windows.Forms.Label();
            this.CreateComplaint = new System.Windows.Forms.TabPage();
            this.Notifications = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
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
            this.ShowAppointments.Location = new System.Drawing.Point(4, 22);
            this.ShowAppointments.Name = "ShowAppointments";
            this.ShowAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.ShowAppointments.Size = new System.Drawing.Size(780, 412);
            this.ShowAppointments.TabIndex = 3;
            this.ShowAppointments.Text = "Show Appointments";
            this.ShowAppointments.UseVisualStyleBackColor = true;
            // 
            // CreateAppointment
            // 
            this.CreateAppointment.Location = new System.Drawing.Point(4, 22);
            this.CreateAppointment.Name = "CreateAppointment";
            this.CreateAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.CreateAppointment.Size = new System.Drawing.Size(780, 412);
            this.CreateAppointment.TabIndex = 1;
            this.CreateAppointment.Text = "Create Appointments";
            this.CreateAppointment.UseVisualStyleBackColor = true;
            // 
            // SplitBill
            // 
            this.SplitBill.Location = new System.Drawing.Point(4, 22);
            this.SplitBill.Name = "SplitBill";
            this.SplitBill.Padding = new System.Windows.Forms.Padding(3);
            //this.SplitBill.Controls.Add(this.btnSplit);
            //this.SplitBill.Controls.Add(this.pbBill);
            //this.SplitBill.Controls.Add(this.btnBrowse);
            //this.SplitBill.Controls.Add(this.textBox3);
            //this.SplitBill.Controls.Add(this.lblPicture);
            //this.SplitBill.Controls.Add(this.lblPrice);
            //this.SplitBill.Controls.Add(this.lblGroceries);
            this.SplitBill.Location = new System.Drawing.Point(4, 22);
            this.SplitBill.Name = "SplitBill";
            this.SplitBill.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.SplitBill.Size = new System.Drawing.Size(780, 412);
            this.SplitBill.TabIndex = 4;
            this.SplitBill.Text = "Split Bill";
            this.SplitBill.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.CreateComplaint.Location = new System.Drawing.Point(4, 22);
            this.CreateComplaint.Name = "CreateComplaint";
            this.CreateComplaint.Size = new System.Drawing.Size(780, 412);
            this.CreateComplaint.TabIndex = 5;
            this.CreateComplaint.Text = "Create Compaint";
            this.CreateComplaint.UseVisualStyleBackColor = true;

            //this.btnSplit.Location = new System.Drawing.Point(482, 304);
            //this.btnSplit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.btnSplit.Name = "btnSplit";
            //this.btnSplit.Size = new System.Drawing.Size(107, 31);
            //this.btnSplit.TabIndex = 6;
            //this.btnSplit.Text = "Split bill";
            //this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // pbBill
            // 
            this.Notifications.Location = new System.Drawing.Point(4, 22);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(780, 412);
            this.Notifications.TabIndex = 6;
            this.Notifications.Text = "Notifications";
            this.Notifications.UseVisualStyleBackColor = true;
            // 
            //this.pbBill.Location = new System.Drawing.Point(404, 108);
            //this.pbBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.pbBill.Name = "pbBill";
            //this.pbBill.Size = new System.Drawing.Size(256, 183);
            //this.pbBill.TabIndex = 5;
            //this.pbBill.TabStop = false;
            //// 
            //// btnBrowse
            //// 
            //this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnBrowse.Location = new System.Drawing.Point(229, 137);
            //this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.btnBrowse.Name = "btnBrowse";
            //this.btnBrowse.Size = new System.Drawing.Size(99, 29);
            //this.btnBrowse.TabIndex = 4;
            //this.btnBrowse.Text = "Browse picture";
            //this.btnBrowse.UseVisualStyleBackColor = true;
            //// 
            //// textBox3
            //// 
            //this.textBox3.Location = new System.Drawing.Point(73, 137);
            //this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.textBox3.Name = "textBox3";
            //this.textBox3.Size = new System.Drawing.Size(83, 20);
            //this.textBox3.TabIndex = 3;
            //// 
            //// lblPicture
            //// 
            //this.lblPicture.AutoSize = true;
            //this.lblPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblPicture.Location = new System.Drawing.Point(233, 108);
            //this.lblPicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            //this.lblPicture.Name = "lblPicture";
            //this.lblPicture.Size = new System.Drawing.Size(85, 20);
            //this.lblPicture.TabIndex = 2;
            //this.lblPicture.Text = "Bill picture:";
            //// 
            //// lblPrice
            //// 
            //this.lblPrice.AutoSize = true;
            //this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblPrice.Location = new System.Drawing.Point(69, 108);
            //this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            //this.lblPrice.Name = "lblPrice";
            //this.lblPrice.Size = new System.Drawing.Size(82, 20);
            //this.lblPrice.TabIndex = 1;
            //this.lblPrice.Text = "Total price";
            //// 
            //// lblGroceries
            //// 
            //this.lblGroceries.AutoSize = true;
            //this.lblGroceries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblGroceries.Location = new System.Drawing.Point(269, 30);
            //this.lblGroceries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            //this.lblGroceries.Name = "lblGroceries";
            //this.lblGroceries.Size = new System.Drawing.Size(165, 26);
            //this.lblGroceries.TabIndex = 0;
            //this.lblGroceries.Text = "All groceries bill";
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantApp";
            this.Text = "TenantApp";
            this.Load += new System.EventHandler(this.TenantApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
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
    }
}

