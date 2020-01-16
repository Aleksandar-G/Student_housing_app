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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDescriptionTitile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbUserName
            // 
            this.LbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LbUserName.Location = new System.Drawing.Point(155, 35);
            this.LbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(46, 17);
            this.LbUserName.TabIndex = 0;
            this.LbUserName.Text = "label1";
            //this.LbUserName.Click += new System.EventHandler(this.LbUserName_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDateTime.Location = new System.Drawing.Point(84, 84);
            this.lbDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(46, 17);
            this.lbDateTime.TabIndex = 1;
            this.lbDateTime.Text = "label2";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(4, 11);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(46, 17);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "label3";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(247, 84);
            this.lbEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(46, 17);
            this.lbEndDate.TabIndex = 3;
            this.lbEndDate.Text = "label1";
            //this.lbEndDate.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(155, 132);
            this.lbRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(46, 17);
            this.lbRoom.TabIndex = 4;
            this.lbRoom.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbDescriptionTitile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LbUserName);
            this.panel1.Controls.Add(this.lbRoom);
            this.panel1.Controls.Add(this.lbDateTime);
            this.panel1.Controls.Add(this.lbEndDate);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 321);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lbDescription);
            this.panel2.Location = new System.Drawing.Point(27, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 92);
            this.panel2.TabIndex = 5;
            // 
            // lbDescriptionTitile
            // 
            this.lbDescriptionTitile.AutoSize = true;
            this.lbDescriptionTitile.Location = new System.Drawing.Point(155, 199);
            this.lbDescriptionTitile.Name = "lbDescriptionTitile";
            this.lbDescriptionTitile.Size = new System.Drawing.Size(79, 17);
            this.lbDescriptionTitile.TabIndex = 6;
            this.lbDescriptionTitile.Text = "Description";
            // 
            // AppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(450, 371);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AppointmentDetails";
            this.Text = "AppointmentDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDescriptionTitile;
        private System.Windows.Forms.Panel panel2;
    }
}