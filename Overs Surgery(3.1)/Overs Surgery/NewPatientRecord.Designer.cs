namespace Overs_Surgery
{
    partial class NewPatientRecord
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
            this.PatientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientEmailTextbox = new System.Windows.Forms.TextBox();
            this.PatientAddressTextbox = new System.Windows.Forms.TextBox();
            this.PatientNameLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.DateofBirthSelector = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // PatientSurnameTextBox
            // 
            this.PatientSurnameTextBox.Location = new System.Drawing.Point(157, 82);
            this.PatientSurnameTextBox.Name = "PatientSurnameTextBox";
            this.PatientSurnameTextBox.Size = new System.Drawing.Size(165, 20);
            this.PatientSurnameTextBox.TabIndex = 0;
            this.PatientSurnameTextBox.TextChanged += new System.EventHandler(this.PatientSUrnameTextBopx_TextChanged);
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Location = new System.Drawing.Point(157, 43);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.PatientNameTextBox.TabIndex = 1;
            this.PatientNameTextBox.TextChanged += new System.EventHandler(this.PatientNameTextBox_TextChanged);
            // 
            // PatientEmailTextbox
            // 
            this.PatientEmailTextbox.Location = new System.Drawing.Point(142, 180);
            this.PatientEmailTextbox.Name = "PatientEmailTextbox";
            this.PatientEmailTextbox.Size = new System.Drawing.Size(225, 20);
            this.PatientEmailTextbox.TabIndex = 3;
            // 
            // PatientAddressTextbox
            // 
            this.PatientAddressTextbox.Location = new System.Drawing.Point(142, 206);
            this.PatientAddressTextbox.Name = "PatientAddressTextbox";
            this.PatientAddressTextbox.Size = new System.Drawing.Size(225, 20);
            this.PatientAddressTextbox.TabIndex = 4;
            this.PatientAddressTextbox.TextChanged += new System.EventHandler(this.PatientAddressTextbox_TextChanged);
            // 
            // PatientNameLable
            // 
            this.PatientNameLable.AutoSize = true;
            this.PatientNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLable.Location = new System.Drawing.Point(47, 50);
            this.PatientNameLable.Name = "PatientNameLable";
            this.PatientNameLable.Size = new System.Drawing.Size(87, 13);
            this.PatientNameLable.TabIndex = 6;
            this.PatientNameLable.Text = "Patient Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patient Surname:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Patient Date Of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Patient Address:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(49, 388);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(85, 62);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit New Record ";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(221, 388);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(85, 62);
            this.HomeButton.TabIndex = 13;
            this.HomeButton.Text = "Home ";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DateofBirthSelector
            // 
            this.DateofBirthSelector.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateofBirthSelector.Location = new System.Drawing.Point(142, 239);
            this.DateofBirthSelector.Name = "DateofBirthSelector";
            this.DateofBirthSelector.Size = new System.Drawing.Size(200, 20);
            this.DateofBirthSelector.TabIndex = 14;
            this.DateofBirthSelector.ValueChanged += new System.EventHandler(this.DateofBirthSelector_ValueChanged);
            // 
            // NewPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 578);
            this.Controls.Add(this.DateofBirthSelector);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientNameLable);
            this.Controls.Add(this.PatientAddressTextbox);
            this.Controls.Add(this.PatientEmailTextbox);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.PatientSurnameTextBox);
            this.Name = "NewPatientRecord";
            this.Text = "New Patient Record Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatientSurnameTextBox;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.TextBox PatientEmailTextbox;
        private System.Windows.Forms.TextBox PatientAddressTextbox;
        private System.Windows.Forms.Label PatientNameLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.DateTimePicker DateofBirthSelector;
    }
}