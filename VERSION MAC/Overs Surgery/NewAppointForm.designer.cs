namespace UI_Appoinment
{
    partial class FormAppointHome
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
            this.ButtonAppointSubmit = new System.Windows.Forms.Button();
            this.LabelAppointPatientName = new System.Windows.Forms.Label();
            this.LabelAppointGPName = new System.Windows.Forms.Label();
            this.AppointDateTime = new System.Windows.Forms.DateTimePicker();
            this.LabelAppointDateTime = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LabelPatientComment = new System.Windows.Forms.Label();
            this.RichTextBoxPatientComments = new System.Windows.Forms.RichTextBox();
            this.GpNurseComboBox = new System.Windows.Forms.ComboBox();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientdateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAppointSubmit
            // 
            this.ButtonAppointSubmit.Location = new System.Drawing.Point(150, 441);
            this.ButtonAppointSubmit.Name = "ButtonAppointSubmit";
            this.ButtonAppointSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonAppointSubmit.TabIndex = 0;
            this.ButtonAppointSubmit.Text = "Submit";
            this.ButtonAppointSubmit.UseVisualStyleBackColor = true;
            this.ButtonAppointSubmit.Click += new System.EventHandler(this.ButtonAppointSubmit_Click_1);
            // 
            // LabelAppointPatientName
            // 
            this.LabelAppointPatientName.AutoSize = true;
            this.LabelAppointPatientName.Location = new System.Drawing.Point(40, 82);
            this.LabelAppointPatientName.Name = "LabelAppointPatientName";
            this.LabelAppointPatientName.Size = new System.Drawing.Size(54, 13);
            this.LabelAppointPatientName.TabIndex = 5;
            this.LabelAppointPatientName.Text = "Patient ID";
            this.LabelAppointPatientName.Click += new System.EventHandler(this.LabelAppointPatientName_Click);
            // 
            // LabelAppointGPName
            // 
            this.LabelAppointGPName.AutoSize = true;
            this.LabelAppointGPName.Location = new System.Drawing.Point(40, 136);
            this.LabelAppointGPName.Name = "LabelAppointGPName";
            this.LabelAppointGPName.Size = new System.Drawing.Size(69, 13);
            this.LabelAppointGPName.TabIndex = 6;
            this.LabelAppointGPName.Text = "GP/Nurse ID";
            this.LabelAppointGPName.Click += new System.EventHandler(this.LabelAppointGPName_Click);
            // 
            // AppointDateTime
            // 
            this.AppointDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppointDateTime.Location = new System.Drawing.Point(12, 248);
            this.AppointDateTime.Name = "AppointDateTime";
            this.AppointDateTime.Size = new System.Drawing.Size(200, 20);
            this.AppointDateTime.TabIndex = 7;
            this.AppointDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LabelAppointDateTime
            // 
            this.LabelAppointDateTime.AutoSize = true;
            this.LabelAppointDateTime.Location = new System.Drawing.Point(12, 232);
            this.LabelAppointDateTime.Name = "LabelAppointDateTime";
            this.LabelAppointDateTime.Size = new System.Drawing.Size(136, 13);
            this.LabelAppointDateTime.TabIndex = 8;
            this.LabelAppointDateTime.Text = "Appoinment Date and Time";
            // 
            // ButtonHome
            // 
            this.ButtonHome.Location = new System.Drawing.Point(12, 13);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(146, 23);
            this.ButtonHome.TabIndex = 11;
            this.ButtonHome.Text = "Appointment Home Page";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // LabelPatientComment
            // 
            this.LabelPatientComment.AutoSize = true;
            this.LabelPatientComment.Location = new System.Drawing.Point(12, 282);
            this.LabelPatientComment.Name = "LabelPatientComment";
            this.LabelPatientComment.Size = new System.Drawing.Size(92, 13);
            this.LabelPatientComment.TabIndex = 19;
            this.LabelPatientComment.Text = "Patient Comments";
            // 
            // RichTextBoxPatientComments
            // 
            this.RichTextBoxPatientComments.Location = new System.Drawing.Point(12, 298);
            this.RichTextBoxPatientComments.Name = "RichTextBoxPatientComments";
            this.RichTextBoxPatientComments.Size = new System.Drawing.Size(349, 128);
            this.RichTextBoxPatientComments.TabIndex = 20;
            this.RichTextBoxPatientComments.Text = "";
            this.RichTextBoxPatientComments.TextChanged += new System.EventHandler(this.RichTextBoxPatientComments_TextChanged);
            // 
            // GpNurseComboBox
            // 
            this.GpNurseComboBox.FormattingEnabled = true;
            this.GpNurseComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.GpNurseComboBox.Location = new System.Drawing.Point(12, 163);
            this.GpNurseComboBox.Name = "GpNurseComboBox";
            this.GpNurseComboBox.Size = new System.Drawing.Size(121, 21);
            this.GpNurseComboBox.TabIndex = 22;
            this.GpNurseComboBox.SelectedIndexChanged += new System.EventHandler(this.GpNurseComboBox_SelectedIndexChanged);
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PatientComboBox.Location = new System.Drawing.Point(12, 98);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(121, 21);
            this.PatientComboBox.TabIndex = 23;
            this.PatientComboBox.SelectedIndexChanged += new System.EventHandler(this.PatientComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Patient Date Of Birth ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatientdateOfBirthTextBox
            // 
            this.PatientdateOfBirthTextBox.Location = new System.Drawing.Point(217, 99);
            this.PatientdateOfBirthTextBox.Name = "PatientdateOfBirthTextBox";
            this.PatientdateOfBirthTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatientdateOfBirthTextBox.TabIndex = 25;
            this.PatientdateOfBirthTextBox.TextChanged += new System.EventHandler(this.PatientdateOfBirthTextBox_TextChanged);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(150, 482);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 26;
            this.btn_Test.Text = "Test Sql";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // FormAppointHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 517);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.PatientdateOfBirthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.GpNurseComboBox);
            this.Controls.Add(this.RichTextBoxPatientComments);
            this.Controls.Add(this.LabelPatientComment);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.LabelAppointDateTime);
            this.Controls.Add(this.AppointDateTime);
            this.Controls.Add(this.LabelAppointGPName);
            this.Controls.Add(this.LabelAppointPatientName);
            this.Controls.Add(this.ButtonAppointSubmit);
            this.Name = "FormAppointHome";
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.FormAppointHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAppointSubmit;
        private System.Windows.Forms.Label LabelAppointPatientName;
        private System.Windows.Forms.Label LabelAppointGPName;
        private System.Windows.Forms.DateTimePicker AppointDateTime;
        private System.Windows.Forms.Label LabelAppointDateTime;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label LabelPatientComment;
        private System.Windows.Forms.RichTextBox RichTextBoxPatientComments;
        private System.Windows.Forms.ComboBox GpNurseComboBox;
        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientdateOfBirthTextBox;
        private System.Windows.Forms.Button btn_Test;
    }
}

