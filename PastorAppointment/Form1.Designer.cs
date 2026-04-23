namespace PastorAppointment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPastorName = new Label();
            txtPastorName = new TextBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblRaison = new Label();
            txtReason = new TextBox();
            lblAdditionalInfo = new Label();
            txtAdditionalInfo = new TextBox();
            lblDate = new Label();
            dtpDateAppointment = new DateTimePicker();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblPastorName
            // 
            lblPastorName.AutoSize = true;
            lblPastorName.Location = new Point(0, 0);
            lblPastorName.Name = "lblPastorName";
            lblPastorName.Size = new Size(222, 41);
            lblPastorName.TabIndex = 0;
            lblPastorName.Text = "Name of Pastor";
            // 
            // txtPastorName
            // 
            txtPastorName.Location = new Point(240, 9);
            txtPastorName.Name = "txtPastorName";
            txtPastorName.Size = new Size(380, 47);
            txtPastorName.TabIndex = 1;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(0, 62);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(131, 41);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(240, 71);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(380, 47);
            txtLocation.TabIndex = 3;
            // 
            // lblRaison
            // 
            lblRaison.AutoSize = true;
            lblRaison.Location = new Point(0, 169);
            lblRaison.Name = "lblRaison";
            lblRaison.Size = new Size(325, 41);
            lblRaison.TabIndex = 4;
            lblRaison.Text = "Raison of Appointment";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(370, 127);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(250, 118);
            txtReason.TabIndex = 5;
            // 
            // lblAdditionalInfo
            // 
            lblAdditionalInfo.AutoSize = true;
            lblAdditionalInfo.Location = new Point(0, 259);
            lblAdditionalInfo.Name = "lblAdditionalInfo";
            lblAdditionalInfo.Size = new Size(316, 41);
            lblAdditionalInfo.TabIndex = 6;
            lblAdditionalInfo.Text = "Additional information";
            // 
            // txtAdditionalInfo
            // 
            txtAdditionalInfo.Location = new Point(370, 269);
            txtAdditionalInfo.Name = "txtAdditionalInfo";
            txtAdditionalInfo.Size = new Size(250, 47);
            txtAdditionalInfo.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(0, 346);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(299, 41);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date of Appointment";
            // 
            // dtpDateAppointment
            // 
            dtpDateAppointment.Location = new Point(305, 346);
            dtpDateAppointment.Name = "dtpDateAppointment";
            dtpDateAppointment.Size = new Size(500, 47);
            dtpDateAppointment.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(112, 484);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(328, 92);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit Appointment";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 660);
            Controls.Add(btnSubmit);
            Controls.Add(dtpDateAppointment);
            Controls.Add(lblDate);
            Controls.Add(txtAdditionalInfo);
            Controls.Add(lblAdditionalInfo);
            Controls.Add(txtReason);
            Controls.Add(lblRaison);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(txtPastorName);
            Controls.Add(lblPastorName);
            Name = "Form1";
            Text = "Pastor Appointment";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox txtAdditionalInfo;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TextBox txtPastorName;
        private Label lblPastorName;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblRaison;
        private TextBox txtReason;
        private Label lblAdditionalInfo;
        private Label lblDate;
        private DateTimePicker dtpDateAppointment;
        private Button btnSubmit;
    }
}
