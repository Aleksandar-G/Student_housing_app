namespace TenantApp
{
    partial class AppointmentDetails
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
            this.LbUserName = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Location = new System.Drawing.Point(79, 37);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(35, 13);
            this.LbUserName.TabIndex = 0;
            this.LbUserName.Text = "label1";
            this.LbUserName.Click += new System.EventHandler(this.LbUserName_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(76, 66);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(35, 13);
            this.lbDateTime.TabIndex = 1;
            this.lbDateTime.Text = "label2";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(76, 190);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(35, 13);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "label3";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(149, 66);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(35, 13);
            this.lbEndDate.TabIndex = 3;
            this.lbEndDate.Text = "label1";
            this.lbEndDate.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(79, 102);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(35, 13);
            this.lbRoom.TabIndex = 4;
            this.lbRoom.Text = "label1";
            // 
            // AppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 371);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.LbUserName);
            this.Name = "AppointmentDetails";
            this.Text = "AppointmentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbRoom;
    }
}