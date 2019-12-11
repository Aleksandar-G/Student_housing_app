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
            this.dtpCreateAppoitment = new System.Windows.Forms.DateTimePicker();
            this.cbRooms = new System.Windows.Forms.ComboBox();
            this.rtbCreateAppoitment = new System.Windows.Forms.RichTextBox();
            this.btnCreateAppoitment = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(89, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pick a Date:";
            // 
            // dtpCreateAppoitment
            // 
            this.dtpCreateAppoitment.Location = new System.Drawing.Point(161, 44);
            this.dtpCreateAppoitment.Name = "dtpCreateAppoitment";
            this.dtpCreateAppoitment.Size = new System.Drawing.Size(200, 20);
            this.dtpCreateAppoitment.TabIndex = 2;
            // 
            // cbRooms
            // 
            this.cbRooms.FormattingEnabled = true;
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
            this.btnCreateAppoitment.Location = new System.Drawing.Point(138, 354);
            this.btnCreateAppoitment.Name = "btnCreateAppoitment";
            this.btnCreateAppoitment.Size = new System.Drawing.Size(180, 45);
            this.btnCreateAppoitment.TabIndex = 5;
            this.btnCreateAppoitment.Text = "Create Appoitment";
            this.btnCreateAppoitment.UseVisualStyleBackColor = true;
            this.btnCreateAppoitment.Click += new System.EventHandler(this.BtnCreateAppoitment_Click);
            // 
            // FormCreateAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 424);
            this.Controls.Add(this.btnCreateAppoitment);
            this.Controls.Add(this.rtbCreateAppoitment);
            this.Controls.Add(this.cbRooms);
            this.Controls.Add(this.dtpCreateAppoitment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateAppoitment";
            this.Text = "FormCreateAppoitment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCreateAppoitment;
        private System.Windows.Forms.ComboBox cbRooms;
        private System.Windows.Forms.RichTextBox rtbCreateAppoitment;
        private System.Windows.Forms.Button btnCreateAppoitment;
    }
}