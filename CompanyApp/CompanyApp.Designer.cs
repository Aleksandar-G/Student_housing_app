namespace CompanyApp
{
    partial class CompanyApp
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.AddTenant = new System.Windows.Forms.TabPage();
            this.RemoveTenant = new System.Windows.Forms.TabPage();
            this.ShowComplaints = new System.Windows.Forms.TabPage();
            this.ShowTenantDetails = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(306, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassword.Location = new System.Drawing.Point(378, 216);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 13;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(387, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.AddTenant);
            this.tabControl1.Controls.Add(this.RemoveTenant);
            this.tabControl1.Controls.Add(this.ShowComplaints);
            this.tabControl1.Controls.Add(this.ShowTenantDetails);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
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
            // AddTenant
            // 
            this.AddTenant.Location = new System.Drawing.Point(4, 22);
            this.AddTenant.Name = "AddTenant";
            this.AddTenant.Padding = new System.Windows.Forms.Padding(3);
            this.AddTenant.Size = new System.Drawing.Size(780, 412);
            this.AddTenant.TabIndex = 1;
            this.AddTenant.Text = "Add Tenant";
            this.AddTenant.UseVisualStyleBackColor = true;
            // 
            // RemoveTenant
            // 
            this.RemoveTenant.Location = new System.Drawing.Point(4, 22);
            this.RemoveTenant.Name = "RemoveTenant";
            this.RemoveTenant.Size = new System.Drawing.Size(780, 412);
            this.RemoveTenant.TabIndex = 3;
            this.RemoveTenant.Text = "Remove Tenant";
            this.RemoveTenant.UseVisualStyleBackColor = true;
            // 
            // ShowComplaints
            // 
            this.ShowComplaints.Location = new System.Drawing.Point(4, 22);
            this.ShowComplaints.Name = "ShowComplaints";
            this.ShowComplaints.Size = new System.Drawing.Size(780, 412);
            this.ShowComplaints.TabIndex = 2;
            this.ShowComplaints.Text = "Show Complaints";
            this.ShowComplaints.UseVisualStyleBackColor = true;
            // 
            // ShowTenantDetails
            // 
            this.ShowTenantDetails.Location = new System.Drawing.Point(4, 22);
            this.ShowTenantDetails.Name = "ShowTenantDetails";
            this.ShowTenantDetails.Size = new System.Drawing.Size(780, 412);
            this.ShowTenantDetails.TabIndex = 4;
            this.ShowTenantDetails.Text = "Show Tenant Details";
            this.ShowTenantDetails.UseVisualStyleBackColor = true;
            // 
            // CompanyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "CompanyApp";
            this.Text = "CompanyApp";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage AddTenant;
        private System.Windows.Forms.TabPage ShowComplaints;
        private System.Windows.Forms.TabPage RemoveTenant;
        private System.Windows.Forms.TabPage ShowTenantDetails;
    }
}

