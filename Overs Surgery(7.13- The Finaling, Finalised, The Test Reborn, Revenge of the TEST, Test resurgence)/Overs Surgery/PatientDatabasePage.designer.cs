namespace Overs_Surgery
{
    partial class PatientDatabasePage
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
            this.txtBxPatientID = new System.Windows.Forms.TextBox();
            this.txtBxPatientName = new System.Windows.Forms.TextBox();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.txtBxDob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatienceDataGridView = new System.Windows.Forms.DataGridView();
            this.PrescriptionDataGridView = new System.Windows.Forms.DataGridView();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PrescriptionTableLabel = new System.Windows.Forms.Label();
            this.PatientTableLable = new System.Windows.Forms.Label();
            this.PrintPatientResult = new System.Windows.Forms.Button();
            this.PrintDoumentButton = new System.Drawing.Printing.PrintDocument();
            this.PrintDialogButton = new System.Windows.Forms.PrintDialog();
            this.ExtendPatientPrescriptionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatienceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxPatientID
            // 
            this.txtBxPatientID.Location = new System.Drawing.Point(260, 104);
            this.txtBxPatientID.Name = "txtBxPatientID";
            this.txtBxPatientID.Size = new System.Drawing.Size(253, 20);
            this.txtBxPatientID.TabIndex = 0;
            this.txtBxPatientID.TextChanged += new System.EventHandler(this.txtBxPatientID_TextChanged_1);
            // 
            // txtBxPatientName
            // 
            this.txtBxPatientName.Location = new System.Drawing.Point(263, 165);
            this.txtBxPatientName.Name = "txtBxPatientName";
            this.txtBxPatientName.Size = new System.Drawing.Size(253, 20);
            this.txtBxPatientName.TabIndex = 1;
            this.txtBxPatientName.TextChanged += new System.EventHandler(this.txtBxPatientName_TextChanged);
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(339, 267);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(101, 79);
            this.btnNewPatient.TabIndex = 5;
            this.btnNewPatient.Text = "Create new patient record";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(258, 35);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(261, 25);
            this.Header.TabIndex = 6;
            this.Header.Text = "Patient Database Page ";
            // 
            // txtBxDob
            // 
            this.txtBxDob.Location = new System.Drawing.Point(263, 227);
            this.txtBxDob.Name = "txtBxDob";
            this.txtBxDob.Size = new System.Drawing.Size(253, 20);
            this.txtBxDob.TabIndex = 7;
            this.txtBxDob.TextChanged += new System.EventHandler(this.txtBxDob_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "PatientID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patient Date of Birth";
            // 
            // PatienceDataGridView
            // 
            this.PatienceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatienceDataGridView.Location = new System.Drawing.Point(96, 378);
            this.PatienceDataGridView.Name = "PatienceDataGridView";
            this.PatienceDataGridView.Size = new System.Drawing.Size(569, 136);
            this.PatienceDataGridView.TabIndex = 11;
            this.PatienceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PrescriptionDataGridView
            // 
            this.PrescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionDataGridView.Location = new System.Drawing.Point(96, 553);
            this.PrescriptionDataGridView.Name = "PrescriptionDataGridView";
            this.PrescriptionDataGridView.Size = new System.Drawing.Size(569, 139);
            this.PrescriptionDataGridView.TabIndex = 12;
            this.PrescriptionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(675, 21);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 13;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PrescriptionTableLabel
            // 
            this.PrescriptionTableLabel.AutoSize = true;
            this.PrescriptionTableLabel.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionTableLabel.Location = new System.Drawing.Point(334, 536);
            this.PrescriptionTableLabel.Name = "PrescriptionTableLabel";
            this.PrescriptionTableLabel.Size = new System.Drawing.Size(106, 14);
            this.PrescriptionTableLabel.TabIndex = 14;
            this.PrescriptionTableLabel.Text = "Prescription Table";
            // 
            // PatientTableLable
            // 
            this.PatientTableLable.AutoSize = true;
            this.PatientTableLable.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientTableLable.Location = new System.Drawing.Point(357, 361);
            this.PatientTableLable.Name = "PatientTableLable";
            this.PatientTableLable.Size = new System.Drawing.Size(79, 14);
            this.PatientTableLable.TabIndex = 15;
            this.PatientTableLable.Text = "Patient Table";
            // 
            // PrintPatientResult
            // 
            this.PrintPatientResult.Location = new System.Drawing.Point(493, 267);
            this.PrintPatientResult.Name = "PrintPatientResult";
            this.PrintPatientResult.Size = new System.Drawing.Size(101, 79);
            this.PrintPatientResult.TabIndex = 16;
            this.PrintPatientResult.Text = "Print Patient Test Result ";
            this.PrintPatientResult.UseVisualStyleBackColor = true;
            this.PrintPatientResult.Click += new System.EventHandler(this.PrintPatientResult_Click);
            // 
            // PrintDoumentButton
            // 
            this.PrintDoumentButton.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDoumentButton_PrintPage);
            // 
            // PrintDialogButton
            // 
            this.PrintDialogButton.UseEXDialog = true;
            // 
            // ExtendPatientPrescriptionButton
            // 
            this.ExtendPatientPrescriptionButton.Location = new System.Drawing.Point(160, 267);
            this.ExtendPatientPrescriptionButton.Name = "ExtendPatientPrescriptionButton";
            this.ExtendPatientPrescriptionButton.Size = new System.Drawing.Size(101, 79);
            this.ExtendPatientPrescriptionButton.TabIndex = 17;
            this.ExtendPatientPrescriptionButton.Text = "Extend Patient Prescription ";
            this.ExtendPatientPrescriptionButton.UseVisualStyleBackColor = true;
            this.ExtendPatientPrescriptionButton.Click += new System.EventHandler(this.ExtendPatientPrescriptionButton_Click);
            // 
            // PatientDatabasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(803, 704);
            this.Controls.Add(this.ExtendPatientPrescriptionButton);
            this.Controls.Add(this.PrintPatientResult);
            this.Controls.Add(this.PatientTableLable);
            this.Controls.Add(this.PrescriptionTableLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.PrescriptionDataGridView);
            this.Controls.Add(this.PatienceDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxDob);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.txtBxPatientName);
            this.Controls.Add(this.txtBxPatientID);
            this.Name = "PatientDatabasePage";
            this.Text = "Patient Database Page";
            this.Load += new System.EventHandler(this.patientDatabasePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatienceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxPatientID;
        private System.Windows.Forms.TextBox txtBxPatientName;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox txtBxDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PatienceDataGridView;
        private System.Windows.Forms.DataGridView PrescriptionDataGridView;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label PrescriptionTableLabel;
        private System.Windows.Forms.Label PatientTableLable;
        private System.Windows.Forms.Button PrintPatientResult;
        private System.Drawing.Printing.PrintDocument PrintDoumentButton;
        private System.Windows.Forms.PrintDialog PrintDialogButton;
        private System.Windows.Forms.Button ExtendPatientPrescriptionButton;
    }
}