namespace StudentHousingApp
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
            this.btnCreateAppoitment = new System.Windows.Forms.Button();
            this.rtbDescriptionAppoitment = new System.Windows.Forms.RichTextBox();
            this.dTPickerCreateAppoitment = new System.Windows.Forms.DateTimePicker();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateAppoitment
            // 
            this.btnCreateAppoitment.Location = new System.Drawing.Point(242, 357);
            this.btnCreateAppoitment.Name = "btnCreateAppoitment";
            this.btnCreateAppoitment.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAppoitment.TabIndex = 16;
            this.btnCreateAppoitment.Text = "Create";
            this.btnCreateAppoitment.UseVisualStyleBackColor = true;
            this.btnCreateAppoitment.Click += new System.EventHandler(this.BtnCreateAppoitment_Click);
            // 
            // rtbDescriptionAppoitment
            // 
            this.rtbDescriptionAppoitment.Location = new System.Drawing.Point(55, 149);
            this.rtbDescriptionAppoitment.Name = "rtbDescriptionAppoitment";
            this.rtbDescriptionAppoitment.Size = new System.Drawing.Size(466, 178);
            this.rtbDescriptionAppoitment.TabIndex = 15;
            this.rtbDescriptionAppoitment.Text = "";
            // 
            // dTPickerCreateAppoitment
            // 
            this.dTPickerCreateAppoitment.Location = new System.Drawing.Point(185, 33);
            this.dTPickerCreateAppoitment.Name = "dTPickerCreateAppoitment";
            this.dTPickerCreateAppoitment.Size = new System.Drawing.Size(200, 20);
            this.dTPickerCreateAppoitment.TabIndex = 14;
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(185, 82);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(100, 20);
            this.tbRoom.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pick a room:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pick a date:";
            // 
            // FormCreateAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 403);
            this.Controls.Add(this.btnCreateAppoitment);
            this.Controls.Add(this.rtbDescriptionAppoitment);
            this.Controls.Add(this.dTPickerCreateAppoitment);
            this.Controls.Add(this.tbRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateAppoitment";
            this.Text = "FormCreateAppoitment";
            this.Load += new System.EventHandler(this.FormCreateAppoitment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAppoitment;
        private System.Windows.Forms.RichTextBox rtbDescriptionAppoitment;
        private System.Windows.Forms.DateTimePicker dTPickerCreateAppoitment;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}