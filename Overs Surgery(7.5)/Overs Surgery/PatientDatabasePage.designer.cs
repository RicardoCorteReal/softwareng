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
            this.button4 = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.txtBxDob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PrescriptionTableLabel = new System.Windows.Forms.Label();
            this.PatientTableLable = new System.Windows.Forms.Label();
            this.dgvTestRes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestRes)).BeginInit();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(638, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 63);
            this.button4.TabIndex = 5;
            this.button4.Text = "Create new patient record";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.label1.Location = new System.Drawing.Point(368, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PatientID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patient Date of Birth";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 136);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(73, 465);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(655, 139);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.PrescriptionTableLabel.Location = new System.Drawing.Point(355, 449);
            this.PrescriptionTableLabel.Name = "PrescriptionTableLabel";
            this.PrescriptionTableLabel.Size = new System.Drawing.Size(92, 13);
            this.PrescriptionTableLabel.TabIndex = 14;
            this.PrescriptionTableLabel.Text = "Prescription Table";
            // 
            // PatientTableLable
            // 
            this.PatientTableLable.AutoSize = true;
            this.PatientTableLable.Location = new System.Drawing.Point(355, 274);
            this.PatientTableLable.Name = "PatientTableLable";
            this.PatientTableLable.Size = new System.Drawing.Size(70, 13);
            this.PatientTableLable.TabIndex = 15;
            this.PatientTableLable.Text = "Patient Table";
            // 
            // dgvTestRes
            // 
            this.dgvTestRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestRes.Location = new System.Drawing.Point(189, 639);
            this.dgvTestRes.Name = "dgvTestRes";
            this.dgvTestRes.Size = new System.Drawing.Size(394, 96);
            this.dgvTestRes.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Test Table";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PatientDatabasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(803, 799);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTestRes);
            this.Controls.Add(this.PatientTableLable);
            this.Controls.Add(this.PrescriptionTableLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxDob);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtBxPatientName);
            this.Controls.Add(this.txtBxPatientID);
            this.Name = "PatientDatabasePage";
            this.Text = "Patient Database Page";
            this.Load += new System.EventHandler(this.patientDatabasePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxPatientID;
        private System.Windows.Forms.TextBox txtBxPatientName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox txtBxDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label PrescriptionTableLabel;
        private System.Windows.Forms.Label PatientTableLable;
        private System.Windows.Forms.DataGridView dgvTestRes;
        private System.Windows.Forms.Label label4;
    }
}