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
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenants = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuildings = new System.Windows.Forms.ComboBox();
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
            this.ShowTenantDetails.SuspendLayout();
            this.ShowComplaints.SuspendLayout();
            this.RemoveTenant.SuspendLayout();
            this.AddTenant.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AddHouseRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowTenantDetails
            // 
            this.ShowTenantDetails.Controls.Add(this.label2);
            this.ShowTenantDetails.Controls.Add(this.lbTenants);
            this.ShowTenantDetails.Controls.Add(this.label1);
            this.ShowTenantDetails.Controls.Add(this.cbBuildings);
            this.ShowTenantDetails.Location = new System.Drawing.Point(4, 23);
            this.ShowTenantDetails.Name = "ShowTenantDetails";
            this.ShowTenantDetails.Size = new System.Drawing.Size(780, 445);
            this.ShowTenantDetails.TabIndex = 4;
            this.ShowTenantDetails.Text = "Show Tenant Details";
            this.ShowTenantDetails.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(327, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tenant Names";
            // 
            // lbTenants
            // 
            this.lbTenants.FormattingEnabled = true;
            this.lbTenants.ItemHeight = 14;
            this.lbTenants.Location = new System.Drawing.Point(217, 156);
            this.lbTenants.Margin = new System.Windows.Forms.Padding(2);
            this.lbTenants.Name = "lbTenants";
            this.lbTenants.Size = new System.Drawing.Size(364, 200);
            this.lbTenants.TabIndex = 2;
            this.lbTenants.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(347, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buildings";
            // 
            // cbBuildings
            // 
            this.cbBuildings.FormattingEnabled = true;
            this.cbBuildings.Location = new System.Drawing.Point(272, 70);
            this.cbBuildings.Margin = new System.Windows.Forms.Padding(2);
            this.cbBuildings.Name = "cbBuildings";
            this.cbBuildings.Size = new System.Drawing.Size(239, 22);
            this.cbBuildings.TabIndex = 0;
            this.cbBuildings.SelectedIndexChanged += new System.EventHandler(this.CbBuildings_SelectedIndexChanged);
            // 
            // ShowComplaints
            // 
            this.ShowComplaints.Controls.Add(this.btnRemoveComplaint);
            this.ShowComplaints.Controls.Add(this.btnShowCurrentComplaint);
            this.ShowComplaints.Controls.Add(this.lbShowAllComplaints);
            this.ShowComplaints.Location = new System.Drawing.Point(4, 23);
            this.ShowComplaints.Name = "ShowComplaints";
            this.ShowComplaints.Size = new System.Drawing.Size(780, 445);
            this.ShowComplaints.TabIndex = 2;
            this.ShowComplaints.Text = "Show Complaints";
            this.ShowComplaints.UseVisualStyleBackColor = true;
            // 
            // btnRemoveComplaint
            // 
            this.btnRemoveComplaint.BackColor = System.Drawing.Color.Red;
            this.btnRemoveComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveComplaint.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnRemoveComplaint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveComplaint.Location = new System.Drawing.Point(323, 104);
            this.btnRemoveComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveComplaint.Name = "btnRemoveComplaint";
            this.btnRemoveComplaint.Size = new System.Drawing.Size(124, 54);
            this.btnRemoveComplaint.TabIndex = 2;
            this.btnRemoveComplaint.Text = "Remove Complaint";
            this.btnRemoveComplaint.UseVisualStyleBackColor = false;
            this.btnRemoveComplaint.Click += new System.EventHandler(this.BtnRemoveComplaint_Click);
            // 
            // btnShowCurrentComplaint
            // 
            this.btnShowCurrentComplaint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowCurrentComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCurrentComplaint.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnShowCurrentComplaint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowCurrentComplaint.Location = new System.Drawing.Point(323, 19);
            this.btnShowCurrentComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowCurrentComplaint.Name = "btnShowCurrentComplaint";
            this.btnShowCurrentComplaint.Size = new System.Drawing.Size(124, 54);
            this.btnShowCurrentComplaint.TabIndex = 1;
            this.btnShowCurrentComplaint.Text = "Show";
            this.btnShowCurrentComplaint.UseVisualStyleBackColor = false;
            this.btnShowCurrentComplaint.Click += new System.EventHandler(this.BtnShowCurrentComplaint_Click);
            // 
            // lbShowAllComplaints
            // 
            this.lbShowAllComplaints.FormattingEnabled = true;
            this.lbShowAllComplaints.ItemHeight = 14;
            this.lbShowAllComplaints.Location = new System.Drawing.Point(16, 19);
            this.lbShowAllComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.lbShowAllComplaints.Name = "lbShowAllComplaints";
            this.lbShowAllComplaints.Size = new System.Drawing.Size(280, 410);
            this.lbShowAllComplaints.TabIndex = 0;
            // 
            // RemoveTenant
            // 
            this.RemoveTenant.Controls.Add(this.btnRemoveTenant);
            this.RemoveTenant.Controls.Add(this.lbRemoveTenantName);
            this.RemoveTenant.Controls.Add(this.cbRemoveTenantEmail);
            this.RemoveTenant.Controls.Add(this.lbRemoveTenantAddress);
            this.RemoveTenant.Controls.Add(this.cbRemoveTenantAddress);
            this.RemoveTenant.Location = new System.Drawing.Point(4, 23);
            this.RemoveTenant.Name = "RemoveTenant";
            this.RemoveTenant.Size = new System.Drawing.Size(780, 445);
            this.RemoveTenant.TabIndex = 3;
            this.RemoveTenant.Text = "Remove Tenant";
            this.RemoveTenant.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemoveTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTenant.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTenant.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveTenant.Location = new System.Drawing.Point(270, 278);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(200, 39);
            this.btnRemoveTenant.TabIndex = 25;
            this.btnRemoveTenant.Text = "Remove Tenant";
            this.btnRemoveTenant.UseVisualStyleBackColor = false;
            this.btnRemoveTenant.Click += new System.EventHandler(this.BtnRemoveTenant_Click);
            // 
            // lbRemoveTenantName
            // 
            this.lbRemoveTenantName.AutoSize = true;
            this.lbRemoveTenantName.Location = new System.Drawing.Point(350, 184);
            this.lbRemoveTenantName.Name = "lbRemoveTenantName";
            this.lbRemoveTenantName.Size = new System.Drawing.Size(42, 14);
            this.lbRemoveTenantName.TabIndex = 24;
            this.lbRemoveTenantName.Text = "Tenant";
            // 
            // cbRemoveTenantEmail
            // 
            this.cbRemoveTenantEmail.FormattingEnabled = true;
            this.cbRemoveTenantEmail.Location = new System.Drawing.Point(270, 201);
            this.cbRemoveTenantEmail.Name = "cbRemoveTenantEmail";
            this.cbRemoveTenantEmail.Size = new System.Drawing.Size(200, 22);
            this.cbRemoveTenantEmail.TabIndex = 23;
            // 
            // lbRemoveTenantAddress
            // 
            this.lbRemoveTenantAddress.AutoSize = true;
            this.lbRemoveTenantAddress.Location = new System.Drawing.Point(350, 88);
            this.lbRemoveTenantAddress.Name = "lbRemoveTenantAddress";
            this.lbRemoveTenantAddress.Size = new System.Drawing.Size(48, 14);
            this.lbRemoveTenantAddress.TabIndex = 22;
            this.lbRemoveTenantAddress.Text = "Address";
            // 
            // cbRemoveTenantAddress
            // 
            this.cbRemoveTenantAddress.FormattingEnabled = true;
            this.cbRemoveTenantAddress.Location = new System.Drawing.Point(270, 106);
            this.cbRemoveTenantAddress.Name = "cbRemoveTenantAddress";
            this.cbRemoveTenantAddress.Size = new System.Drawing.Size(200, 22);
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
            this.AddTenant.Location = new System.Drawing.Point(4, 23);
            this.AddTenant.Name = "AddTenant";
            this.AddTenant.Padding = new System.Windows.Forms.Padding(3);
            this.AddTenant.Size = new System.Drawing.Size(780, 445);
            this.AddTenant.TabIndex = 1;
            this.AddTenant.Text = "Add Tenant";
            this.AddTenant.UseVisualStyleBackColor = true;
            // 
            // cbAddTenantRoomNumber
            // 
            this.cbAddTenantRoomNumber.FormattingEnabled = true;
            this.cbAddTenantRoomNumber.Location = new System.Drawing.Point(287, 330);
            this.cbAddTenantRoomNumber.Name = "cbAddTenantRoomNumber";
            this.cbAddTenantRoomNumber.Size = new System.Drawing.Size(200, 22);
            this.cbAddTenantRoomNumber.TabIndex = 6;
            // 
            // lblAddTenantRoomId
            // 
            this.lblAddTenantRoomId.AutoSize = true;
            this.lblAddTenantRoomId.Location = new System.Drawing.Point(350, 311);
            this.lblAddTenantRoomId.Name = "lblAddTenantRoomId";
            this.lblAddTenantRoomId.Size = new System.Drawing.Size(81, 14);
            this.lblAddTenantRoomId.TabIndex = 22;
            this.lblAddTenantRoomId.Text = "Room Number";
            // 
            // lbAddTenantAddress
            // 
            this.lbAddTenantAddress.AutoSize = true;
            this.lbAddTenantAddress.Location = new System.Drawing.Point(367, 252);
            this.lbAddTenantAddress.Name = "lbAddTenantAddress";
            this.lbAddTenantAddress.Size = new System.Drawing.Size(48, 14);
            this.lbAddTenantAddress.TabIndex = 20;
            this.lbAddTenantAddress.Text = "Address";
            // 
            // cbAddTenantAddress
            // 
            this.cbAddTenantAddress.FormattingEnabled = true;
            this.cbAddTenantAddress.Location = new System.Drawing.Point(287, 269);
            this.cbAddTenantAddress.Name = "cbAddTenantAddress";
            this.cbAddTenantAddress.Size = new System.Drawing.Size(200, 22);
            this.cbAddTenantAddress.TabIndex = 19;
            this.cbAddTenantAddress.SelectedIndexChanged += new System.EventHandler(this.CbAddTenantAddress_SelectedIndexChanged);
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTenant.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnAddTenant.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddTenant.Location = new System.Drawing.Point(287, 372);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(200, 44);
            this.btnAddTenant.TabIndex = 15;
            this.btnAddTenant.Text = "Add Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = false;
            this.btnAddTenant.Click += new System.EventHandler(this.BtnAddTenant_Click);
            // 
            // tbAddTenantPhone
            // 
            this.tbAddTenantPhone.Location = new System.Drawing.Point(287, 218);
            this.tbAddTenantPhone.Name = "tbAddTenantPhone";
            this.tbAddTenantPhone.Size = new System.Drawing.Size(200, 21);
            this.tbAddTenantPhone.TabIndex = 17;
            // 
            // tbAddTenantName
            // 
            this.tbAddTenantName.Location = new System.Drawing.Point(287, 55);
            this.tbAddTenantName.Name = "tbAddTenantName";
            this.tbAddTenantName.Size = new System.Drawing.Size(200, 21);
            this.tbAddTenantName.TabIndex = 1;
            // 
            // tbAddTenantPassword
            // 
            this.tbAddTenantPassword.Location = new System.Drawing.Point(287, 163);
            this.tbAddTenantPassword.Name = "tbAddTenantPassword";
            this.tbAddTenantPassword.PasswordChar = '*';
            this.tbAddTenantPassword.Size = new System.Drawing.Size(200, 21);
            this.tbAddTenantPassword.TabIndex = 3;
            // 
            // tbAddTenantEmail
            // 
            this.tbAddTenantEmail.Location = new System.Drawing.Point(287, 109);
            this.tbAddTenantEmail.Name = "tbAddTenantEmail";
            this.tbAddTenantEmail.Size = new System.Drawing.Size(200, 21);
            this.tbAddTenantEmail.TabIndex = 2;
            // 
            // lbAddTenantPhone
            // 
            this.lbAddTenantPhone.AutoSize = true;
            this.lbAddTenantPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddTenantPhone.Location = new System.Drawing.Point(368, 200);
            this.lbAddTenantPhone.Name = "lbAddTenantPhone";
            this.lbAddTenantPhone.Size = new System.Drawing.Size(40, 14);
            this.lbAddTenantPhone.TabIndex = 18;
            this.lbAddTenantPhone.Text = "Phone";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassword.Location = new System.Drawing.Point(359, 145);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 14);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Password";
            // 
            // lbAddTenantName
            // 
            this.lbAddTenantName.AutoSize = true;
            this.lbAddTenantName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddTenantName.Location = new System.Drawing.Point(368, 38);
            this.lbAddTenantName.Name = "lbAddTenantName";
            this.lbAddTenantName.Size = new System.Drawing.Size(36, 14);
            this.lbAddTenantName.TabIndex = 16;
            this.lbAddTenantName.Text = "Name";
            this.lbAddTenantName.Click += new System.EventHandler(this.LbAddTenantName_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(368, 92);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(34, 14);
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 472);
            this.tabControl1.TabIndex = 10;
            // 
            // AddHouseRules
            // 
            this.AddHouseRules.Controls.Add(this.btnAddRule);
            this.AddHouseRules.Controls.Add(this.lblAddRules);
            this.AddHouseRules.Controls.Add(this.tbHouseRules);
            this.AddHouseRules.Controls.Add(this.cbHouseRulesAddress);
            this.AddHouseRules.Controls.Add(this.lblSelectBuilding);
            this.AddHouseRules.Location = new System.Drawing.Point(4, 23);
            this.AddHouseRules.Margin = new System.Windows.Forms.Padding(2);
            this.AddHouseRules.Name = "AddHouseRules";
            this.AddHouseRules.Size = new System.Drawing.Size(780, 445);
            this.AddHouseRules.TabIndex = 5;
            this.AddHouseRules.Text = "Add House Rules";
            this.AddHouseRules.UseVisualStyleBackColor = true;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(529, 387);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(116, 42);
            this.btnAddRule.TabIndex = 4;
            this.btnAddRule.Text = "Add Rules:";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // lblAddRules
            // 
            this.lblAddRules.AutoSize = true;
            this.lblAddRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRules.Location = new System.Drawing.Point(525, 75);
            this.lblAddRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddRules.Name = "lblAddRules";
            this.lblAddRules.Size = new System.Drawing.Size(97, 20);
            this.lblAddRules.TabIndex = 3;
            this.lblAddRules.Text = "Add Rules:";
            // 
            // tbHouseRules
            // 
            this.tbHouseRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHouseRules.Location = new System.Drawing.Point(385, 113);
            this.tbHouseRules.Margin = new System.Windows.Forms.Padding(2);
            this.tbHouseRules.Multiline = true;
            this.tbHouseRules.Name = "tbHouseRules";
            this.tbHouseRules.Size = new System.Drawing.Size(371, 261);
            this.tbHouseRules.TabIndex = 2;
            // 
            // cbHouseRulesAddress
            // 
            this.cbHouseRulesAddress.FormattingEnabled = true;
            this.cbHouseRulesAddress.Location = new System.Drawing.Point(37, 99);
            this.cbHouseRulesAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cbHouseRulesAddress.Name = "cbHouseRulesAddress";
            this.cbHouseRulesAddress.Size = new System.Drawing.Size(297, 22);
            this.cbHouseRulesAddress.TabIndex = 1;
            this.cbHouseRulesAddress.SelectedIndexChanged += new System.EventHandler(this.CbHouseRulesAddress_SelectedIndexChanged);
            // 
            // lblSelectBuilding
            // 
            this.lblSelectBuilding.AutoSize = true;
            this.lblSelectBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBuilding.Location = new System.Drawing.Point(125, 75);
            this.lblSelectBuilding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectBuilding.Name = "lblSelectBuilding";
            this.lblSelectBuilding.Size = new System.Drawing.Size(132, 20);
            this.lblSelectBuilding.TabIndex = 0;
            this.lblSelectBuilding.Text = "Select building:";
            // 
            // CompanyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CompanyApp";
            this.Text = "CompanyApp";
            this.Load += new System.EventHandler(this.CompanyApp_Load);
            this.ShowTenantDetails.ResumeLayout(false);
            this.ShowTenantDetails.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTenants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBuildings;
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

