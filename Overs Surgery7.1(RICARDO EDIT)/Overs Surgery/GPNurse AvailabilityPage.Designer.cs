namespace Overs_Surgery
{
    partial class GPNurse_AvailabilityPage
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
            this.RoleLabel = new System.Windows.Forms.Label();
            this.DatabaseDisplay = new System.Windows.Forms.DataGridView();
            this.RoleSearchBox = new System.Windows.Forms.TextBox();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.OnDutyButton = new System.Windows.Forms.Label();
            this.YesAndNoComboBox = new System.Windows.Forms.ComboBox();
            this.ReturnToAppointmentPageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(19, 97);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(59, 24);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Role:";
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseDisplay.Location = new System.Drawing.Point(264, 26);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(626, 283);
            this.DatabaseDisplay.TabIndex = 8;
            this.DatabaseDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RoleSearchBox
            // 
            this.RoleSearchBox.Location = new System.Drawing.Point(107, 102);
            this.RoleSearchBox.Name = "RoleSearchBox";
            this.RoleSearchBox.Size = new System.Drawing.Size(136, 20);
            this.RoleSearchBox.TabIndex = 1;
            this.RoleSearchBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Location = new System.Drawing.Point(19, 136);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(58, 24);
            this.DateTimeLabel.TabIndex = 10;
            this.DateTimeLabel.Text = "Date:";
            // 
            // OnDutyButton
            // 
            this.OnDutyButton.AutoSize = true;
            this.OnDutyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnDutyButton.Location = new System.Drawing.Point(1, 199);
            this.OnDutyButton.Name = "OnDutyButton";
            this.OnDutyButton.Size = new System.Drawing.Size(100, 24);
            this.OnDutyButton.TabIndex = 11;
            this.OnDutyButton.Text = " On duty?";
            // 
            // YesAndNoComboBox
            // 
            this.YesAndNoComboBox.FormattingEnabled = true;
            this.YesAndNoComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.YesAndNoComboBox.Location = new System.Drawing.Point(112, 199);
            this.YesAndNoComboBox.Name = "YesAndNoComboBox";
            this.YesAndNoComboBox.Size = new System.Drawing.Size(131, 21);
            this.YesAndNoComboBox.TabIndex = 13;
            this.YesAndNoComboBox.SelectedIndexChanged += new System.EventHandler(this.YesAndNoComboBox_SelectedIndexChanged);
            // 
            // ReturnToAppointmentPageButton
            // 
            this.ReturnToAppointmentPageButton.Location = new System.Drawing.Point(107, 295);
            this.ReturnToAppointmentPageButton.Name = "ReturnToAppointmentPageButton";
            this.ReturnToAppointmentPageButton.Size = new System.Drawing.Size(131, 83);
            this.ReturnToAppointmentPageButton.TabIndex = 14;
            this.ReturnToAppointmentPageButton.Text = "Return To Appointment Page";
            this.ReturnToAppointmentPageButton.UseVisualStyleBackColor = true;
            this.ReturnToAppointmentPageButton.Click += new System.EventHandler(this.AppointmentPageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Staff Availability Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(107, 136);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(136, 20);
            this.DateTextBox.TabIndex = 16;
            this.DateTextBox.TextChanged += new System.EventHandler(this.DateTextBox_TextChanged);
            // 
            // GPNurse_AvailabilityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 390);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnToAppointmentPageButton);
            this.Controls.Add(this.YesAndNoComboBox);
            this.Controls.Add(this.OnDutyButton);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.DatabaseDisplay);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.RoleSearchBox);
            this.Name = "GPNurse_AvailabilityPage";
            this.Text = "GPNurse_AvailabilityPage";
            this.Load += new System.EventHandler(this.GPNurse_AvailabilityPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.DataGridView DatabaseDisplay;
        private System.Windows.Forms.TextBox RoleSearchBox;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Label OnDutyButton;
        private System.Windows.Forms.ComboBox YesAndNoComboBox;
        private System.Windows.Forms.Button ReturnToAppointmentPageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateTextBox;
    }
}