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
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(101, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(81, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pick a Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "YYYY-MM-DD";
            this.dtpStartDate.Location = new System.Drawing.Point(198, 30);
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
            this.cbRooms.Location = new System.Drawing.Point(198, 114);
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
            this.btnCreateAppoitment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateAppoitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAppoitment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateAppoitment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateAppoitment.Location = new System.Drawing.Point(139, 371);
            this.btnCreateAppoitment.Name = "btnCreateAppoitment";
            this.btnCreateAppoitment.Size = new System.Drawing.Size(180, 45);
            this.btnCreateAppoitment.TabIndex = 5;
            this.btnCreateAppoitment.Text = "Create Appoitment";
            this.btnCreateAppoitment.UseVisualStyleBackColor = false;
            this.btnCreateAppoitment.Click += new System.EventHandler(this.BtnCreateAppoitment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(101, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "From:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "H:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(151, 71);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(74, 20);
            this.dtpStartTime.TabIndex = 8;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "H:mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(281, 71);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(74, 20);
            this.dtpEndTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(246, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "To:";
            // 
            // FormCreateAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(476, 447);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
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
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label4;
    }
}