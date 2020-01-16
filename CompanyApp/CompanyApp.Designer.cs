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
            this.ShowTenantDetails = new System.Windows.Forms.TabPage();
            this.ShowComplaints = new System.Windows.Forms.TabPage();
            this.btnRemoveComplaint = new System.Windows.Forms.Button();
            this.btnShowCurrentComplaint = new System.Windows.Forms.Button();
            this.lbShowAllComplaints = new System.Windows.Forms.ListBox();
            this.RemoveTenant = new System.Windows.Forms.TabPage();
            this.btnRemoveTenant = new System.Windows.Forms.Button();
            this.lbRemoveTenantName = new System.Windows.Forms.Label();
            this.cbRemoveTenantEmail = new System.Windows.Forms.ComboBox();
            this.lbRemoveTenantAddress = new System.Windows.Forms.Label();
            this.cbRemoveTenantAddress = new System.Windows.Forms.ComboBox();
            this.AddTenant = new System.Windows.Forms.TabPage();
            this.cbAddTenantRoomNumber = new System.Windows.Forms.ComboBox();
            this.lblAddTenantRoomId = new System.Windows.Forms.Label();
            this.lbAddTenantAddress = new System.Windows.Forms.Label();
            this.cbAddTenantAddress = new System.Windows.Forms.ComboBox();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.tbAddTenantPhone = new System.Windows.Forms.TextBox();
            this.tbAddTenantName = new System.Windows.Forms.TextBox();
            this.tbAddTenantPassword = new System.Windows.Forms.TextBox();
            this.tbAddTenantEmail = new System.Windows.Forms.TextBox();
            this.lbAddTenantPhone = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbAddTenantName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddHouseRules = new System.Windows.Forms.TabPage();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lblAddRules = new System.Windows.Forms.Label();
            this.tbHouseRules = new System.Windows.Forms.TextBox();
            this.cbHouseRulesAddress = new System.Windows.Forms.ComboBox();
            this.lblSelectBuilding = new System.Windows.Forms.Label();
            this.ShowComplaints.SuspendLayout();
            this.RemoveTenant.SuspendLayout();
            this.AddTenant.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AddHouseRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowTenantDetails
            // 
            this.ShowTenantDetails.Location = new System.Drawing.Point(4, 29);
            this.ShowTenantDetails.Margin = new System.Windows.Forms.Padding(4);
            this.ShowTenantDetails.Name = "ShowTenantDetails";
            this.ShowTenantDetails.Size = new System.Drawing.Size(1205, 664);
            this.ShowTenantDetails.TabIndex = 4;
            this.ShowTenantDetails.Text = "Show Tenant Details";
            this.ShowTenantDetails.UseVisualStyleBackColor = true;
            // 
            // ShowComplaints
            // 
            this.ShowComplaints.Controls.Add(this.btnRemoveComplaint);
            this.ShowComplaints.Controls.Add(this.btnShowCurrentComplaint);
            this.ShowComplaints.Controls.Add(this.lbShowAllComplaints);
            this.ShowComplaints.Location = new System.Drawing.Point(4, 29);
            this.ShowComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.ShowComplaints.Name = "ShowComplaints";
            this.ShowComplaints.Size = new System.Drawing.Size(1205, 664);
            this.ShowComplaints.TabIndex = 2;
            this.ShowComplaints.Text = "Show Complaints";
            this.ShowComplaints.UseVisualStyleBackColor = true;
            // 
            // btnRemoveComplaint
            // 
            this.btnRemoveComplaint.BackColor = System.Drawing.Color.Red;
            this.btnRemoveComplaint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRemoveComplaint.Location = new System.Drawing.Point(431, 119);
            this.btnRemoveComplaint.Name = "btnRemoveComplaint";
            this.btnRemoveComplaint.Size = new System.Drawing.Size(165, 62);
            this.btnRemoveComplaint.TabIndex = 2;
            this.btnRemoveComplaint.Text = "Remove Complaint";
            this.btnRemoveComplaint.UseVisualStyleBackColor = false;
            this.btnRemoveComplaint.Click += new System.EventHandler(this.BtnRemoveComplaint_Click);
            // 
            // btnShowCurrentComplaint
            // 
            this.btnShowCurrentComplaint.Location = new System.Drawing.Point(431, 22);
            this.btnShowCurrentComplaint.Name = "btnShowCurrentComplaint";
            this.btnShowCurrentComplaint.Size = new System.Drawing.Size(165, 62);
            this.btnShowCurrentComplaint.TabIndex = 1;
            this.btnShowCurrentComplaint.Text = "Show";
            this.btnShowCurrentComplaint.UseVisualStyleBackColor = true;
            this.btnShowCurrentComplaint.Click += new System.EventHandler(this.BtnShowCurrentComplaint_Click);
            // 
            // lbShowAllComplaints
            // 
            this.lbShowAllComplaints.FormattingEnabled = true;
            this.lbShowAllComplaints.ItemHeight = 20;
            this.lbShowAllComplaints.Location = new System.Drawing.Point(22, 22);
            this.lbShowAllComplaints.Name = "lbShowAllComplaints";
            this.lbShowAllComplaints.Size = new System.Drawing.Size(372, 464);
            this.lbShowAllComplaints.TabIndex = 0;
            // 
            // RemoveTenant
            // 
            this.RemoveTenant.Controls.Add(this.btnRemoveTenant);
            this.RemoveTenant.Controls.Add(this.lbRemoveTenantName);
            this.RemoveTenant.Controls.Add(this.cbRemoveTenantEmail);
            this.RemoveTenant.Controls.Add(this.lbRemoveTenantAddress);
            this.RemoveTenant.Controls.Add(this.cbRemoveTenantAddress);
            this.RemoveTenant.Location = new System.Drawing.Point(4, 29);
            this.RemoveTenant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveTenant.Name = "RemoveTenant";
            this.RemoveTenant.Size = new System.Drawing.Size(1205, 664);
            this.RemoveTenant.TabIndex = 3;
            this.RemoveTenant.Text = "Remove Tenant";
            this.RemoveTenant.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.Location = new System.Drawing.Point(360, 334);
            this.btnRemoveTenant.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(273, 45);
            this.btnRemoveTenant.TabIndex = 25;
            this.btnRemoveTenant.Text = "Remove Tenant";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            this.btnRemoveTenant.Click += new System.EventHandler(this.BtnRemoveTenant_Click);
            // 
            // lbRemoveTenantName
            // 
            this.lbRemoveTenantName.AutoSize = true;
            this.lbRemoveTenantName.Location = new System.Drawing.Point(467, 210);
            this.lbRemoveTenantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRemoveTenantName.Name = "lbRemoveTenantName";
            this.lbRemoveTenantName.Size = new System.Drawing.Size(59, 20);
            this.lbRemoveTenantName.TabIndex = 24;
            this.lbRemoveTenantName.Text = "Tenant";
            // 
            // cbRemoveTenantEmail
            // 
            this.cbRemoveTenantEmail.FormattingEnabled = true;
            this.cbRemoveTenantEmail.Location = new System.Drawing.Point(360, 230);
            this.cbRemoveTenantEmail.Margin = new System.Windows.Forms.Padding(4);
            this.cbRemoveTenantEmail.Name = "cbRemoveTenantEmail";
            this.cbRemoveTenantEmail.Size = new System.Drawing.Size(265, 28);
            this.cbRemoveTenantEmail.TabIndex = 23;
            // 
            // lbRemoveTenantAddress
            // 
            this.lbRemoveTenantAddress.AutoSize = true;
            this.lbRemoveTenantAddress.Location = new System.Drawing.Point(467, 101);
            this.lbRemoveTenantAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRemoveTenantAddress.Name = "lbRemoveTenantAddress";
            this.lbRemoveTenantAddress.Size = new System.Drawing.Size(68, 20);
            this.lbRemoveTenantAddress.TabIndex = 22;
            this.lbRemoveTenantAddress.Text = "Address";
            // 
            // cbRemoveTenantAddress
            // 
            this.cbRemoveTenantAddress.FormattingEnabled = true;
            this.cbRemoveTenantAddress.Location = new System.Drawing.Point(360, 121);
            this.cbRemoveTenantAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cbRemoveTenantAddress.Name = "cbRemoveTenantAddress";
            this.cbRemoveTenantAddress.Size = new System.Drawing.Size(265, 28);
            this.cbRemoveTenantAddress.TabIndex = 21;
            this.cbRemoveTenantAddress.SelectedIndexChanged += new System.EventHandler(this.CbRemoveTenantAddress_SelectedIndexChanged);
            // 
            // AddTenant
            // 
            this.AddTenant.Controls.Add(this.cbAddTenantRoomNumber);
            this.AddTenant.Controls.Add(this.lblAddTenantRoomId);
            this.AddTenant.Controls.Add(this.lbAddTenantAddress);
            this.AddTenant.Controls.Add(this.cbAddTenantAddress);
            this.AddTenant.Controls.Add(this.btnAddTenant);
            this.AddTenant.Controls.Add(this.tbAddTenantPhone);
            this.AddTenant.Controls.Add(this.tbAddTenantName);
            this.AddTenant.Controls.Add(this.tbAddTenantPassword);
            this.AddTenant.Controls.Add(this.tbAddTenantEmail);
            this.AddTenant.Controls.Add(this.lbAddTenantPhone);
            this.AddTenant.Controls.Add(this.lbPassword);
            this.AddTenant.Controls.Add(this.lbAddTenantName);
            this.AddTenant.Controls.Add(this.lbEmail);
            this.AddTenant.Location = new System.Drawing.Point(4, 29);
            this.AddTenant.Margin = new System.Windows.Forms.Padding(4);
            this.AddTenant.Name = "AddTenant";
            this.AddTenant.Padding = new System.Windows.Forms.Padding(4);
            this.AddTenant.Size = new System.Drawing.Size(1205, 664);
            this.AddTenant.TabIndex = 1;
            this.AddTenant.Text = "Add Tenant";
            this.AddTenant.UseVisualStyleBackColor = true;
            // 
            // cbAddTenantRoomNumber
            // 
            this.cbAddTenantRoomNumber.FormattingEnabled = true;
            this.cbAddTenantRoomNumber.Location = new System.Drawing.Point(383, 426);
            this.cbAddTenantRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAddTenantRoomNumber.Name = "cbAddTenantRoomNumber";
            this.cbAddTenantRoomNumber.Size = new System.Drawing.Size(272, 28);
            this.cbAddTenantRoomNumber.TabIndex = 6;
            // 
            // lblAddTenantRoomId
            // 
            this.lblAddTenantRoomId.AutoSize = true;
            this.lblAddTenantRoomId.Location = new System.Drawing.Point(479, 401);
            this.lblAddTenantRoomId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddTenantRoomId.Name = "lblAddTenantRoomId";
            this.lblAddTenantRoomId.Size = new System.Drawing.Size(112, 20);
            this.lblAddTenantRoomId.TabIndex = 22;
            this.lblAddTenantRoomId.Text = "Room Number";
            // 
            // lbAddTenantAddress
            // 
            this.lbAddTenantAddress.AutoSize = true;
            this.lbAddTenantAddress.Location = new System.Drawing.Point(491, 314);
            this.lbAddTenantAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddTenantAddress.Name = "lbAddTenantAddress";
            this.lbAddTenantAddress.Size = new System.Drawing.Size(68, 20);
            this.lbAddTenantAddress.TabIndex = 20;
            this.lbAddTenantAddress.Text = "Address";
            // 
            // cbAddTenantAddress
            // 
            this.cbAddTenantAddress.FormattingEnabled = true;
            this.cbAddTenantAddress.Location = new System.Drawing.Point(383, 338);
            this.cbAddTenantAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddTenantAddress.Name = "cbAddTenantAddress";
            this.cbAddTenantAddress.Size = new System.Drawing.Size(265, 28);
            this.cbAddTenantAddress.TabIndex = 19;
            this.cbAddTenantAddress.SelectedIndexChanged += new System.EventHandler(this.CbAddTenantAddress_SelectedIndexChanged);
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Location = new System.Drawing.Point(383, 513);
            this.btnAddTenant.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(272, 50);
            this.btnAddTenant.TabIndex = 15;
            this.btnAddTenant.Text = "Add Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.BtnAddTenant_Click);
            // 
            // tbAddTenantPhone
            // 
            this.tbAddTenantPhone.Location = new System.Drawing.Point(385, 262);
            this.tbAddTenantPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddTenantPhone.Name = "tbAddTenantPhone";
            this.tbAddTenantPhone.Size = new System.Drawing.Size(265, 26);
            this.tbAddTenantPhone.TabIndex = 17;
            // 
            // tbAddTenantName
            // 
            this.tbAddTenantName.Location = new System.Drawing.Point(385, 44);
            this.tbAddTenantName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddTenantName.Name = "tbAddTenantName";
            this.tbAddTenantName.Size = new System.Drawing.Size(267, 26);
            this.tbAddTenantName.TabIndex = 1;
            // 
            // tbAddTenantPassword
            // 
            this.tbAddTenantPassword.Location = new System.Drawing.Point(383, 186);
            this.tbAddTenantPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddTenantPassword.Name = "tbAddTenantPassword";
            this.tbAddTenantPassword.PasswordChar = '*';
            this.tbAddTenantPassword.Size = new System.Drawing.Size(265, 26);
            this.tbAddTenantPassword.TabIndex = 3;
            // 
            // tbAddTenantEmail
            // 
            this.tbAddTenantEmail.Location = new System.Drawing.Point(383, 115);
            this.tbAddTenantEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddTenantEmail.Name = "tbAddTenantEmail";
            this.tbAddTenantEmail.Size = new System.Drawing.Size(265, 26);
            this.tbAddTenantEmail.TabIndex = 2;
            // 
            // lbAddTenantPhone
            // 
            this.lbAddTenantPhone.AutoSize = true;
            this.lbAddTenantPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddTenantPhone.Location = new System.Drawing.Point(491, 238);
            this.lbAddTenantPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddTenantPhone.Name = "lbAddTenantPhone";
            this.lbAddTenantPhone.Size = new System.Drawing.Size(55, 20);
            this.lbAddTenantPhone.TabIndex = 18;
            this.lbAddTenantPhone.Text = "Phone";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassword.Location = new System.Drawing.Point(479, 166);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(78, 20);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Password";
            // 
            // lbAddTenantName
            // 
            this.lbAddTenantName.AutoSize = true;
            this.lbAddTenantName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddTenantName.Location = new System.Drawing.Point(491, 19);
            this.lbAddTenantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddTenantName.Name = "lbAddTenantName";
            this.lbAddTenantName.Size = new System.Drawing.Size(51, 20);
            this.lbAddTenantName.TabIndex = 16;
            this.lbAddTenantName.Text = "Name";
            this.lbAddTenantName.Click += new System.EventHandler(this.LbAddTenantName_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(491, 91);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddTenant);
            this.tabControl1.Controls.Add(this.RemoveTenant);
            this.tabControl1.Controls.Add(this.ShowComplaints);
            this.tabControl1.Controls.Add(this.ShowTenantDetails);
            this.tabControl1.Controls.Add(this.AddHouseRules);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1213, 697);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // AddHouseRules
            // 
            this.AddHouseRules.Controls.Add(this.btnAddRule);
            this.AddHouseRules.Controls.Add(this.lblAddRules);
            this.AddHouseRules.Controls.Add(this.tbHouseRules);
            this.AddHouseRules.Controls.Add(this.cbHouseRulesAddress);
            this.AddHouseRules.Controls.Add(this.lblSelectBuilding);
            this.AddHouseRules.Location = new System.Drawing.Point(4, 29);
            this.AddHouseRules.Name = "AddHouseRules";
            this.AddHouseRules.Size = new System.Drawing.Size(1205, 664);
            this.AddHouseRules.TabIndex = 5;
            this.AddHouseRules.Text = "Add House Rules";
            this.AddHouseRules.UseVisualStyleBackColor = true;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(793, 552);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(174, 60);
            this.btnAddRule.TabIndex = 4;
            this.btnAddRule.Text = "Add Rules:";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // lblAddRules
            // 
            this.lblAddRules.AutoSize = true;
            this.lblAddRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRules.Location = new System.Drawing.Point(788, 107);
            this.lblAddRules.Name = "lblAddRules";
            this.lblAddRules.Size = new System.Drawing.Size(130, 29);
            this.lblAddRules.TabIndex = 3;
            this.lblAddRules.Text = "Add Rules:";
            // 
            // tbHouseRules
            // 
            this.tbHouseRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHouseRules.Location = new System.Drawing.Point(578, 162);
            this.tbHouseRules.Multiline = true;
            this.tbHouseRules.Name = "tbHouseRules";
            this.tbHouseRules.Size = new System.Drawing.Size(555, 371);
            this.tbHouseRules.TabIndex = 2;
            // 
            // cbHouseRulesAddress
            // 
            this.cbHouseRulesAddress.FormattingEnabled = true;
            this.cbHouseRulesAddress.Location = new System.Drawing.Point(55, 142);
            this.cbHouseRulesAddress.Name = "cbHouseRulesAddress";
            this.cbHouseRulesAddress.Size = new System.Drawing.Size(444, 28);
            this.cbHouseRulesAddress.TabIndex = 1;
            // 
            // lblSelectBuilding
            // 
            this.lblSelectBuilding.AutoSize = true;
            this.lblSelectBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBuilding.Location = new System.Drawing.Point(193, 107);
            this.lblSelectBuilding.Name = "lblSelectBuilding";
            this.lblSelectBuilding.Size = new System.Drawing.Size(179, 29);
            this.lblSelectBuilding.TabIndex = 0;
            this.lblSelectBuilding.Text = "Select building:";
            // 
            // CompanyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompanyApp";
            this.Text = "CompanyApp";
            this.Load += new System.EventHandler(this.CompanyApp_Load);
            this.ShowComplaints.ResumeLayout(false);
            this.RemoveTenant.ResumeLayout(false);
            this.RemoveTenant.PerformLayout();
            this.AddTenant.ResumeLayout(false);
            this.AddTenant.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.AddHouseRules.ResumeLayout(false);
            this.AddHouseRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ShowTenantDetails;
        private System.Windows.Forms.TabPage ShowComplaints;
        private System.Windows.Forms.TabPage RemoveTenant;
        private System.Windows.Forms.TabPage AddTenant;
        private System.Windows.Forms.ComboBox cbAddTenantRoomNumber;
        private System.Windows.Forms.Label lblAddTenantRoomId;
        private System.Windows.Forms.Label lbAddTenantAddress;
        private System.Windows.Forms.ComboBox cbAddTenantAddress;
        private System.Windows.Forms.Button btnAddTenant;
        private System.Windows.Forms.TextBox tbAddTenantPhone;
        private System.Windows.Forms.TextBox tbAddTenantName;
        private System.Windows.Forms.TextBox tbAddTenantPassword;
        private System.Windows.Forms.TextBox tbAddTenantEmail;
        private System.Windows.Forms.Label lbAddTenantPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbAddTenantName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbRemoveTenantName;
        private System.Windows.Forms.ComboBox cbRemoveTenantEmail;
        private System.Windows.Forms.Label lbRemoveTenantAddress;
        private System.Windows.Forms.ComboBox cbRemoveTenantAddress;
        private System.Windows.Forms.Button btnRemoveTenant;
        private System.Windows.Forms.ListBox lbShowAllComplaints;
        private System.Windows.Forms.Button btnShowCurrentComplaint;
        private System.Windows.Forms.Button btnRemoveComplaint;
        private System.Windows.Forms.TabPage AddHouseRules;
        private System.Windows.Forms.Label lblAddRules;
        private System.Windows.Forms.TextBox tbHouseRules;
        private System.Windows.Forms.ComboBox cbHouseRulesAddress;
        private System.Windows.Forms.Label lblSelectBuilding;
        private System.Windows.Forms.Button btnAddRule;
    }
}

