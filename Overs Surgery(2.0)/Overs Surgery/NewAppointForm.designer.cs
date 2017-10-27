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
            this.TextAppointBoxPatientName = new System.Windows.Forms.TextBox();
            this.LabelAppointPatientName = new System.Windows.Forms.Label();
            this.LabelAppointGPName = new System.Windows.Forms.Label();
            this.AppointDateTime = new System.Windows.Forms.DateTimePicker();
            this.LabelAppointDateTime = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LabelPatientDOB = new System.Windows.Forms.Label();
            this.TextBoxPatientDOB = new System.Windows.Forms.TextBox();
            this.ListBoxGPs = new System.Windows.Forms.ListBox();
            this.RadioUrgent = new System.Windows.Forms.RadioButton();
            this.LabelPatientComment = new System.Windows.Forms.Label();
            this.RichTextBoxPatientComments = new System.Windows.Forms.RichTextBox();
            this.ButtonCancelAppoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAppointSubmit
            // 
            this.ButtonAppointSubmit.Location = new System.Drawing.Point(158, 445);
            this.ButtonAppointSubmit.Name = "ButtonAppointSubmit";
            this.ButtonAppointSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonAppointSubmit.TabIndex = 0;
            this.ButtonAppointSubmit.Text = "Submit";
            this.ButtonAppointSubmit.UseVisualStyleBackColor = true;
            // 
            // TextAppointBoxPatientName
            // 
            this.TextAppointBoxPatientName.Location = new System.Drawing.Point(12, 101);
            this.TextAppointBoxPatientName.Name = "TextAppointBoxPatientName";
            this.TextAppointBoxPatientName.Size = new System.Drawing.Size(100, 20);
            this.TextAppointBoxPatientName.TabIndex = 1;
            // 
            // LabelAppointPatientName
            // 
            this.LabelAppointPatientName.AutoSize = true;
            this.LabelAppointPatientName.Location = new System.Drawing.Point(9, 85);
            this.LabelAppointPatientName.Name = "LabelAppointPatientName";
            this.LabelAppointPatientName.Size = new System.Drawing.Size(71, 13);
            this.LabelAppointPatientName.TabIndex = 5;
            this.LabelAppointPatientName.Text = "Patient Name";
            // 
            // LabelAppointGPName
            // 
            this.LabelAppointGPName.AutoSize = true;
            this.LabelAppointGPName.Location = new System.Drawing.Point(12, 141);
            this.LabelAppointGPName.Name = "LabelAppointGPName";
            this.LabelAppointGPName.Size = new System.Drawing.Size(53, 13);
            this.LabelAppointGPName.TabIndex = 6;
            this.LabelAppointGPName.Text = "GP Name";
            // 
            // AppointDateTime
            // 
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
            this.ButtonHome.Size = new System.Drawing.Size(75, 23);
            this.ButtonHome.TabIndex = 11;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // LabelPatientDOB
            // 
            this.LabelPatientDOB.AutoSize = true;
            this.LabelPatientDOB.Location = new System.Drawing.Point(155, 85);
            this.LabelPatientDOB.Name = "LabelPatientDOB";
            this.LabelPatientDOB.Size = new System.Drawing.Size(102, 13);
            this.LabelPatientDOB.TabIndex = 13;
            this.LabelPatientDOB.Text = "Patient Date of Birth";
            // 
            // TextBoxPatientDOB
            // 
            this.TextBoxPatientDOB.Location = new System.Drawing.Point(158, 101);
            this.TextBoxPatientDOB.Name = "TextBoxPatientDOB";
            this.TextBoxPatientDOB.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPatientDOB.TabIndex = 14;
            // 
            // ListBoxGPs
            // 
            this.ListBoxGPs.FormattingEnabled = true;
            this.ListBoxGPs.Location = new System.Drawing.Point(12, 157);
            this.ListBoxGPs.Name = "ListBoxGPs";
            this.ListBoxGPs.Size = new System.Drawing.Size(120, 43);
            this.ListBoxGPs.TabIndex = 15;
            // 
            // RadioUrgent
            // 
            this.RadioUrgent.AutoSize = true;
            this.RadioUrgent.Location = new System.Drawing.Point(158, 157);
            this.RadioUrgent.Name = "RadioUrgent";
            this.RadioUrgent.Size = new System.Drawing.Size(119, 17);
            this.RadioUrgent.TabIndex = 16;
            this.RadioUrgent.TabStop = true;
            this.RadioUrgent.Text = "Urgent Appointment";
            this.RadioUrgent.UseVisualStyleBackColor = true;
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
            // 
            // ButtonCancelAppoint
            // 
            this.ButtonCancelAppoint.Location = new System.Drawing.Point(158, 474);
            this.ButtonCancelAppoint.Name = "ButtonCancelAppoint";
            this.ButtonCancelAppoint.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelAppoint.TabIndex = 21;
            this.ButtonCancelAppoint.Text = "Cancel";
            this.ButtonCancelAppoint.UseVisualStyleBackColor = true;
            // 
            // FormAppointHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 517);
            this.Controls.Add(this.ButtonCancelAppoint);
            this.Controls.Add(this.RichTextBoxPatientComments);
            this.Controls.Add(this.LabelPatientComment);
            this.Controls.Add(this.RadioUrgent);
            this.Controls.Add(this.ListBoxGPs);
            this.Controls.Add(this.TextBoxPatientDOB);
            this.Controls.Add(this.LabelPatientDOB);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.LabelAppointDateTime);
            this.Controls.Add(this.AppointDateTime);
            this.Controls.Add(this.LabelAppointGPName);
            this.Controls.Add(this.LabelAppointPatientName);
            this.Controls.Add(this.TextAppointBoxPatientName);
            this.Controls.Add(this.ButtonAppointSubmit);
            this.Name = "FormAppointHome";
            this.Text = "New Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAppointSubmit;
        private System.Windows.Forms.TextBox TextAppointBoxPatientName;
        private System.Windows.Forms.Label LabelAppointPatientName;
        private System.Windows.Forms.Label LabelAppointGPName;
        private System.Windows.Forms.DateTimePicker AppointDateTime;
        private System.Windows.Forms.Label LabelAppointDateTime;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label LabelPatientDOB;
        private System.Windows.Forms.TextBox TextBoxPatientDOB;
        private System.Windows.Forms.ListBox ListBoxGPs;
        private System.Windows.Forms.RadioButton RadioUrgent;
        private System.Windows.Forms.Label LabelPatientComment;
        private System.Windows.Forms.RichTextBox RichTextBoxPatientComments;
        private System.Windows.Forms.Button ButtonCancelAppoint;
    }
}

