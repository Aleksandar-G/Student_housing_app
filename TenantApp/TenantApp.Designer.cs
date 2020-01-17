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
            this.ShowAppointments = new System.Windows.Forms.TabPage();
            this.dtpShowAppointments = new System.Windows.Forms.DateTimePicker();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.btnPrevDate = new System.Windows.Forms.Button();
            this.btnGoCreateAppoitment = new System.Windows.Forms.Button();
            this.lbAppoitments = new System.Windows.Forms.ListBox();
            this.SplitBill = new System.Windows.Forms.TabPage();
            this.pbBill = new System.Windows.Forms.PictureBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGroceries = new System.Windows.Forms.Label();
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
            this.HouseRules = new System.Windows.Forms.TabPage();
            this.tbHouseRules = new System.Windows.Forms.TextBox();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.ShowAppointments.SuspendLayout();
            this.SplitBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBill)).BeginInit();
            this.CreateComplaint.SuspendLayout();
            this.HouseRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ShowAppointments);
            this.tabControl1.Controls.Add(this.SplitBill);
            this.tabControl1.Controls.Add(this.CreateComplaint);
            this.tabControl1.Controls.Add(this.Notifications);
            this.tabControl1.Controls.Add(this.HouseRules);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 420);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.TabControl1_TabIndexChanged);
            // 
            // ShowAppointments
            // 
            this.ShowAppointments.BackColor = System.Drawing.SystemColors.Window;
            this.ShowAppointments.Controls.Add(this.dtpShowAppointments);
            this.ShowAppointments.Controls.Add(this.btnNextDate);
            this.ShowAppointments.Controls.Add(this.btnPrevDate);
            this.ShowAppointments.Controls.Add(this.btnGoCreateAppoitment);
            this.ShowAppointments.Controls.Add(this.lbAppoitments);
            this.ShowAppointments.Location = new System.Drawing.Point(4, 22);
            this.ShowAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAppointments.Name = "ShowAppointments";
            this.ShowAppointments.Padding = new System.Windows.Forms.Padding(2);
            this.ShowAppointments.Size = new System.Drawing.Size(794, 394);
            this.ShowAppointments.TabIndex = 3;
            this.ShowAppointments.Text = "Show Appointments";
            // 
            // dtpShowAppointments
            // 
            this.dtpShowAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpShowAppointments.Location = new System.Drawing.Point(280, 42);
            this.dtpShowAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dtpShowAppointments.Name = "dtpShowAppointments";
            this.dtpShowAppointments.Size = new System.Drawing.Size(243, 21);
            this.dtpShowAppointments.TabIndex = 4;
            // 
            // btnNextDate
            // 
            this.btnNextDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNextDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNextDate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNextDate.Location = new System.Drawing.Point(537, 39);
            this.btnNextDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(33, 33);
            this.btnNextDate.TabIndex = 3;
            this.btnNextDate.Text = ">";
            this.btnNextDate.UseVisualStyleBackColor = false;
            this.btnNextDate.Click += new System.EventHandler(this.BtnNextDate_Click);
            // 
            // btnPrevDate
            // 
            this.btnPrevDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrevDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrevDate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrevDate.Location = new System.Drawing.Point(231, 39);
            this.btnPrevDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevDate.Name = "btnPrevDate";
            this.btnPrevDate.Size = new System.Drawing.Size(33, 33);
            this.btnPrevDate.TabIndex = 2;
            this.btnPrevDate.Text = "<";
            this.btnPrevDate.UseVisualStyleBackColor = false;
            this.btnPrevDate.Click += new System.EventHandler(this.BtnPrevDate_Click);
            // 
            // btnGoCreateAppoitment
            // 
            this.btnGoCreateAppoitment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGoCreateAppoitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoCreateAppoitment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGoCreateAppoitment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGoCreateAppoitment.Location = new System.Drawing.Point(299, 305);
            this.btnGoCreateAppoitment.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoCreateAppoitment.Name = "btnGoCreateAppoitment";
            this.btnGoCreateAppoitment.Size = new System.Drawing.Size(199, 59);
            this.btnGoCreateAppoitment.TabIndex = 1;
            this.btnGoCreateAppoitment.Text = "Create Appointment";
            this.btnGoCreateAppoitment.UseVisualStyleBackColor = false;
            this.btnGoCreateAppoitment.Click += new System.EventHandler(this.BtnCreateAppoitment_Click);
            // 
            // lbAppoitments
            // 
            this.lbAppoitments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbAppoitments.FormattingEnabled = true;
            this.lbAppoitments.ItemHeight = 15;
            this.lbAppoitments.Location = new System.Drawing.Point(166, 95);
            this.lbAppoitments.Margin = new System.Windows.Forms.Padding(2);
            this.lbAppoitments.Name = "lbAppoitments";
            this.lbAppoitments.Size = new System.Drawing.Size(470, 184);
            this.lbAppoitments.TabIndex = 0;
            this.lbAppoitments.DoubleClick += new System.EventHandler(this.LbAppoitments_DoubleClick);
            // 
            // SplitBill
            // 
            this.SplitBill.Controls.Add(this.pbBill);
            this.SplitBill.Controls.Add(this.btnSplit);
            this.SplitBill.Controls.Add(this.btnBrowse);
            this.SplitBill.Controls.Add(this.tbPrice);
            this.SplitBill.Controls.Add(this.lblPicture);
            this.SplitBill.Controls.Add(this.lblPrice);
            this.SplitBill.Controls.Add(this.lblGroceries);
            this.SplitBill.Location = new System.Drawing.Point(4, 22);
            this.SplitBill.Name = "SplitBill";
            this.SplitBill.Padding = new System.Windows.Forms.Padding(1);
            this.SplitBill.Size = new System.Drawing.Size(794, 394);
            this.SplitBill.TabIndex = 4;
            this.SplitBill.Text = "Split Bill";
            this.SplitBill.UseVisualStyleBackColor = true;
            // 
            // pbBill
            // 
            this.pbBill.Location = new System.Drawing.Point(131, 75);
            this.pbBill.Margin = new System.Windows.Forms.Padding(1);
            this.pbBill.Name = "pbBill";
            this.pbBill.Size = new System.Drawing.Size(277, 246);
            this.pbBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBill.TabIndex = 7;
            this.pbBill.TabStop = false;
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSplit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSplit.Location = new System.Drawing.Point(550, 168);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(1);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(107, 31);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split bill";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.Location = new System.Drawing.Point(21, 102);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 29);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse picture";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(550, 135);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(1);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(108, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicture.Location = new System.Drawing.Point(26, 75);
            this.lblPicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(85, 20);
            this.lblPicture.TabIndex = 2;
            this.lblPicture.Text = "Bill picture:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(559, 107);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Total price";
            // 
            // lblGroceries
            // 
            this.lblGroceries.AutoSize = true;
            this.lblGroceries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroceries.Location = new System.Drawing.Point(258, 31);
            this.lblGroceries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroceries.Name = "lblGroceries";
            this.lblGroceries.Size = new System.Drawing.Size(183, 26);
            this.lblGroceries.TabIndex = 0;
            this.lblGroceries.Text = "Split groceries bill";
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
            this.CreateComplaint.Size = new System.Drawing.Size(794, 394);
            this.CreateComplaint.TabIndex = 5;
            this.CreateComplaint.Text = "Create Compaint";
            this.CreateComplaint.UseVisualStyleBackColor = true;
            // 
            // cbBuildingId
            // 
            this.cbBuildingId.FormattingEnabled = true;
            this.cbBuildingId.Location = new System.Drawing.Point(470, 112);
            this.cbBuildingId.Margin = new System.Windows.Forms.Padding(1);
            this.cbBuildingId.Name = "cbBuildingId";
            this.cbBuildingId.Size = new System.Drawing.Size(163, 28);
            this.cbBuildingId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Building:";
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitComplaint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmitComplaint.Location = new System.Drawing.Point(293, 308);
            this.btnSubmitComplaint.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(205, 52);
            this.btnSubmitComplaint.TabIndex = 5;
            this.btnSubmitComplaint.Text = "Submit Complaint";
            this.btnSubmitComplaint.UseVisualStyleBackColor = false;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.BtnSubmitComplaint_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(185, 161);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(1);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(430, 123);
            this.tbMessage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(185, 112);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(1);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(163, 26);
            this.tbTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Complaint";
            // 
            // Notifications
            // 
            this.Notifications.AutoScroll = true;
            this.Notifications.Location = new System.Drawing.Point(4, 22);
            this.Notifications.Margin = new System.Windows.Forms.Padding(2);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(794, 394);
            this.Notifications.TabIndex = 6;
            this.Notifications.Text = "Notifications";
            this.Notifications.UseVisualStyleBackColor = true;
            // 
            // HouseRules
            // 
            this.HouseRules.Controls.Add(this.tbHouseRules);
            this.HouseRules.Controls.Add(this.lblHouseRules);
            this.HouseRules.Location = new System.Drawing.Point(4, 22);
            this.HouseRules.Margin = new System.Windows.Forms.Padding(2);
            this.HouseRules.Name = "HouseRules";
            this.HouseRules.Size = new System.Drawing.Size(794, 394);
            this.HouseRules.TabIndex = 7;
            this.HouseRules.Text = "House Rules";
            this.HouseRules.UseVisualStyleBackColor = true;
            // 
            // tbHouseRules
            // 
            this.tbHouseRules.BackColor = System.Drawing.Color.White;
            this.tbHouseRules.Enabled = false;
            this.tbHouseRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHouseRules.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbHouseRules.Location = new System.Drawing.Point(166, 74);
            this.tbHouseRules.Margin = new System.Windows.Forms.Padding(2);
            this.tbHouseRules.Multiline = true;
            this.tbHouseRules.Name = "tbHouseRules";
            this.tbHouseRules.Size = new System.Drawing.Size(485, 238);
            this.tbHouseRules.TabIndex = 2;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseRules.Location = new System.Drawing.Point(307, 26);
            this.lblHouseRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(194, 36);
            this.lblHouseRules.TabIndex = 1;
            this.lblHouseRules.Text = "House Rules:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse Bill Picture";
            // 
            // TenantApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 427);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantApp";
            this.Text = "TenantApp";
            this.Load += new System.EventHandler(this.TenantApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.ShowAppointments.ResumeLayout(false);
            this.SplitBill.ResumeLayout(false);
            this.SplitBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBill)).EndInit();
            this.CreateComplaint.ResumeLayout(false);
            this.CreateComplaint.PerformLayout();
            this.HouseRules.ResumeLayout(false);
            this.HouseRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ShowAppointments;
        private System.Windows.Forms.TabPage SplitBill;
        private System.Windows.Forms.TabPage CreateComplaint;
        private System.Windows.Forms.TabPage Notifications;

        private System.Windows.Forms.DateTimePicker dtpShowAppointments;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.Button btnPrevDate;
        private System.Windows.Forms.Button btnGoCreateAppoitment;
        private System.Windows.Forms.ListBox lbAppoitments;

        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGroceries;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbBill;

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitComplaint;
        private System.Windows.Forms.ComboBox cbBuildingId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage HouseRules;
        private System.Windows.Forms.TextBox tbHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
    }
}

