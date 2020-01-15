namespace CompanyApp
{
    partial class TenantDetailsForm
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
            this.lbname = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbroom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbname.Location = new System.Drawing.Point(191, 82);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(46, 17);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "label1";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbemail.Location = new System.Drawing.Point(191, 123);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(46, 17);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "label2";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbphone.Location = new System.Drawing.Point(191, 166);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(46, 17);
            this.lbphone.TabIndex = 2;
            this.lbphone.Text = "label3";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbaddress.Location = new System.Drawing.Point(191, 206);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(46, 17);
            this.lbaddress.TabIndex = 3;
            this.lbaddress.Text = "label4";
            // 
            // lbroom
            // 
            this.lbroom.AutoSize = true;
            this.lbroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbroom.Location = new System.Drawing.Point(191, 245);
            this.lbroom.Name = "lbroom";
            this.lbroom.Size = new System.Drawing.Size(46, 17);
            this.lbroom.TabIndex = 4;
            this.lbroom.Text = "label1";
            // 
            // TenantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 371);
            this.Controls.Add(this.lbroom);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbphone);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbname);
            this.Name = "TenantDetails";
            this.Text = "TenantDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbroom;
    }
}