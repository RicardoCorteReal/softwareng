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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CheckAvailabilityButton = new System.Windows.Forms.Button();
            this.GpNurseLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GPNurseSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // CheckAvailabilityButton
            // 
            this.CheckAvailabilityButton.Location = new System.Drawing.Point(15, 183);
            this.CheckAvailabilityButton.Name = "CheckAvailabilityButton";
            this.CheckAvailabilityButton.Size = new System.Drawing.Size(136, 23);
            this.CheckAvailabilityButton.TabIndex = 2;
            this.CheckAvailabilityButton.Text = "Check Availability";
            this.CheckAvailabilityButton.UseVisualStyleBackColor = true;
            // 
            // GpNurseLabel
            // 
            this.GpNurseLabel.AutoSize = true;
            this.GpNurseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpNurseLabel.Location = new System.Drawing.Point(12, 62);
            this.GpNurseLabel.Name = "GpNurseLabel";
            this.GpNurseLabel.Size = new System.Drawing.Size(103, 13);
            this.GpNurseLabel.TabIndex = 3;
            this.GpNurseLabel.Text = "GP/Nurse Name:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(82, 122);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(37, 13);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Role:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // GPNurseSurname
            // 
            this.GPNurseSurname.AutoSize = true;
            this.GPNurseSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPNurseSurname.Location = new System.Drawing.Point(2, 96);
            this.GPNurseSurname.Name = "GPNurseSurname";
            this.GPNurseSurname.Size = new System.Drawing.Size(120, 13);
            this.GPNurseSurname.TabIndex = 6;
            this.GPNurseSurname.Text = "GP/Nurse Surname:";
            // 
            // GPNurse_AvailabilityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.GPNurseSurname);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.GpNurseLabel);
            this.Controls.Add(this.CheckAvailabilityButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "GPNurse_AvailabilityPage";
            this.Text = "GPNurse_AvailabilityPage";
            this.Load += new System.EventHandler(this.GPNurse_AvailabilityPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CheckAvailabilityButton;
        private System.Windows.Forms.Label GpNurseLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label GPNurseSurname;
    }
}