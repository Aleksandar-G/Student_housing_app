namespace TenantApp
{
    partial class FormCreateAppoitment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbRooms = new System.Windows.Forms.ComboBox();
            this.rtbCreateAppoitment = new System.Windows.Forms.RichTextBox();
            this.btnCreateAppoitment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pick a Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "YYYY-MM-DD";
            this.dtpStartDate.Location = new System.Drawing.Point(119, 23);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // cbRooms
            // 
            this.cbRooms.FormattingEnabled = true;
            this.cbRooms.Items.AddRange(new object[] {
            "Kitchen",
            "DinnigRoom",
            "FrontYard",
            "BackYard",
            "ChillRoom",
            "GameRoom"});
            this.cbRooms.Location = new System.Drawing.Point(166, 99);
            this.cbRooms.Name = "cbRooms";
            this.cbRooms.Size = new System.Drawing.Size(121, 21);
            this.cbRooms.TabIndex = 3;
            // 
            // rtbCreateAppoitment
            // 
            this.rtbCreateAppoitment.Location = new System.Drawing.Point(64, 151);
            this.rtbCreateAppoitment.Name = "rtbCreateAppoitment";
            this.rtbCreateAppoitment.Size = new System.Drawing.Size(324, 184);
            this.rtbCreateAppoitment.TabIndex = 4;
            this.rtbCreateAppoitment.Text = "";
            // 
            // btnCreateAppoitment
            // 
            this.btnCreateAppoitment.Location = new System.Drawing.Point(139, 371);
            this.btnCreateAppoitment.Name = "btnCreateAppoitment";
            this.btnCreateAppoitment.Size = new System.Drawing.Size(180, 45);
            this.btnCreateAppoitment.TabIndex = 5;
            this.btnCreateAppoitment.Text = "Create Appoitment";
            this.btnCreateAppoitment.UseVisualStyleBackColor = true;
            this.btnCreateAppoitment.Click += new System.EventHandler(this.BtnCreateAppoitment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pick a End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(120, 57);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(199, 20);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "H:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(325, 23);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(74, 20);
            this.dtpStartTime.TabIndex = 8;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(325, 56);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(74, 20);
            this.dtpEndTime.TabIndex = 9;
            this.dtpEndTime.CustomFormat = "H:mm:ss";
            // 
            // FormCreateAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 447);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateAppoitment);
            this.Controls.Add(this.rtbCreateAppoitment);
            this.Controls.Add(this.cbRooms);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateAppoitment";
            this.Text = "FormCreateAppoitment";
            this.Load += new System.EventHandler(this.FormCreateAppoitment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbRooms;
        private System.Windows.Forms.RichTextBox rtbCreateAppoitment;
        private System.Windows.Forms.Button btnCreateAppoitment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
    }
}