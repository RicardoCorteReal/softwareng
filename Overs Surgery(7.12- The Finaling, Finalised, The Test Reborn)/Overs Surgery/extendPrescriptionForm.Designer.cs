namespace Overs_Surgery
{
    partial class ExtendPrescriptionForm
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
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.PatientIDtxtBox = new System.Windows.Forms.TextBox();
            this.PatientIDLabel = new System.Windows.Forms.Label();
            this.endDateSelector = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(2, 116);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(164, 13);
            this.textBoxLabel.TabIndex = 1;
            this.textBoxLabel.Text = "New Prescription End Date ";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(172, 139);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // PatientIDtxtBox
            // 
            this.PatientIDtxtBox.Location = new System.Drawing.Point(172, 87);
            this.PatientIDtxtBox.Name = "PatientIDtxtBox";
            this.PatientIDtxtBox.Size = new System.Drawing.Size(32, 20);
            this.PatientIDtxtBox.TabIndex = 3;
            this.PatientIDtxtBox.TextChanged += new System.EventHandler(this.PatientIDtxtBox_TextChanged);
            // 
            // PatientIDLabel
            // 
            this.PatientIDLabel.AutoSize = true;
            this.PatientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIDLabel.Location = new System.Drawing.Point(2, 90);
            this.PatientIDLabel.Name = "PatientIDLabel";
            this.PatientIDLabel.Size = new System.Drawing.Size(64, 13);
            this.PatientIDLabel.TabIndex = 4;
            this.PatientIDLabel.Text = "Patient ID";
            // 
            // endDateSelector
            // 
            this.endDateSelector.Location = new System.Drawing.Point(172, 116);
            this.endDateSelector.Name = "endDateSelector";
            this.endDateSelector.Size = new System.Drawing.Size(122, 20);
            this.endDateSelector.TabIndex = 5;
            // 
            // ExtendPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.endDateSelector);
            this.Controls.Add(this.PatientIDLabel);
            this.Controls.Add(this.PatientIDtxtBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.textBoxLabel);
            this.Name = "ExtendPrescriptionForm";
            this.Text = "extendPrescriptionForm";
            this.Load += new System.EventHandler(this.extendPrescriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox PatientIDtxtBox;
        private System.Windows.Forms.Label PatientIDLabel;
        private System.Windows.Forms.DateTimePicker endDateSelector;
    }
}