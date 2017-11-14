namespace Overs_Surgery
{
    using UI_Appoinment;
    partial class AppointmentPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentPage));
            this.HomePageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MakeNewAppointButton = new System.Windows.Forms.Button();
            this.CheckAvailability = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.patientDatabaseDataSet = new Overs_Surgery.PatientDatabaseDataSet();
            this.patientDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDatabaseDataSet1 = new Overs_Surgery.PatientDatabaseDataSet1();
            this.appointmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointment_TableTableAdapter = new Overs_Surgery.PatientDatabaseDataSet1TableAdapters.Appointment_TableTableAdapter();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePageButton
            // 
            this.HomePageButton.Location = new System.Drawing.Point(45, 105);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(75, 23);
            this.HomePageButton.TabIndex = 0;
            this.HomePageButton.Text = "Home Page";
            this.HomePageButton.UseVisualStyleBackColor = true;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Overs_Surgery.Properties.Resources.key_hole_symbol_secret_indiscret_sign_classic_round_sticker_r2de28769a86d4f4ca8d4dcdb7df99cdd_v9waf_8byvr_630;
            this.pictureBox2.Location = new System.Drawing.Point(216, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Overs_Surgery.Properties.Resources.Hey;
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MakeNewAppointButton
            // 
            this.MakeNewAppointButton.Location = new System.Drawing.Point(190, 105);
            this.MakeNewAppointButton.Name = "MakeNewAppointButton";
            this.MakeNewAppointButton.Size = new System.Drawing.Size(151, 23);
            this.MakeNewAppointButton.TabIndex = 5;
            this.MakeNewAppointButton.Text = "Make New Appointment ";
            this.MakeNewAppointButton.UseVisualStyleBackColor = true;
            this.MakeNewAppointButton.Click += new System.EventHandler(this.MakeNewAppointButton_Click);
            // 
            // CheckAvailability
            // 
            this.CheckAvailability.Location = new System.Drawing.Point(367, 103);
            this.CheckAvailability.Name = "CheckAvailability";
            this.CheckAvailability.Size = new System.Drawing.Size(228, 25);
            this.CheckAvailability.TabIndex = 6;
            this.CheckAvailability.Text = "Check GPs and Nurses Availability ";
            this.CheckAvailability.UseVisualStyleBackColor = true;
            this.CheckAvailability.Click += new System.EventHandler(this.CheckAvailability_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn,
            this.appointmentStatusDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.patientDateOfBirthDataGridViewTextBoxColumn,
            this.appointmentCommentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 191);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(446, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // patientDatabaseDataSet
            // 
            this.patientDatabaseDataSet.DataSetName = "PatientDatabaseDataSet";
            this.patientDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDatabaseDataSetBindingSource
            // 
            this.patientDatabaseDataSetBindingSource.DataSource = this.patientDatabaseDataSet;
            this.patientDatabaseDataSetBindingSource.Position = 0;
            // 
            // patientDatabaseDataSet1
            // 
            this.patientDatabaseDataSet1.DataSetName = "PatientDatabaseDataSet1";
            this.patientDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableBindingSource
            // 
            this.appointmentTableBindingSource.DataMember = "Appointment_Table";
            this.appointmentTableBindingSource.DataSource = this.patientDatabaseDataSet1;
            // 
            // appointment_TableTableAdapter
            // 
            this.appointment_TableTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "Appointment_ID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "Appointment_ID";
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            this.appointmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Date";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "Appointment_Date";
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // appointmentStatusDataGridViewTextBoxColumn
            // 
            this.appointmentStatusDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Status ";
            this.appointmentStatusDataGridViewTextBoxColumn.HeaderText = "Appointment_Status ";
            this.appointmentStatusDataGridViewTextBoxColumn.Name = "appointmentStatusDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // patientDateOfBirthDataGridViewTextBoxColumn
            // 
            this.patientDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Patient_Date_Of_Birth";
            this.patientDateOfBirthDataGridViewTextBoxColumn.HeaderText = "Patient_Date_Of_Birth";
            this.patientDateOfBirthDataGridViewTextBoxColumn.Name = "patientDateOfBirthDataGridViewTextBoxColumn";
            // 
            // appointmentCommentDataGridViewTextBoxColumn
            // 
            this.appointmentCommentDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Comment ";
            this.appointmentCommentDataGridViewTextBoxColumn.HeaderText = "Appointment_Comment ";
            this.appointmentCommentDataGridViewTextBoxColumn.Name = "appointmentCommentDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(832, 168);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(832, 197);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 362);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CheckAvailability);
            this.Controls.Add(this.MakeNewAppointButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HomePageButton);
            this.Name = "AppointmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment Page";
            this.Load += new System.EventHandler(this.AppointmentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button MakeNewAppointButton;
        private System.Windows.Forms.Button CheckAvailability;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingSource patientDatabaseDataSetBindingSource;
        private PatientDatabaseDataSet patientDatabaseDataSet;
        private PatientDatabaseDataSet1 patientDatabaseDataSet1;
        private System.Windows.Forms.BindingSource appointmentTableBindingSource;
        private PatientDatabaseDataSet1TableAdapters.Appointment_TableTableAdapter appointment_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
    }
}