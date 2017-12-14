﻿namespace Overs_Surgery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentPage));
            this.HomePageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MakeNewAppointButton = new System.Windows.Forms.Button();
            this.CheckAvailability = new System.Windows.Forms.Button();
            this.AppointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePageButton
            // 
            this.HomePageButton.Location = new System.Drawing.Point(465, 114);
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
            this.pictureBox2.Location = new System.Drawing.Point(99, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Overs_Surgery.Properties.Resources.Hey;
            this.pictureBox1.Location = new System.Drawing.Point(455, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MakeNewAppointButton
            // 
            this.MakeNewAppointButton.Location = new System.Drawing.Point(99, 114);
            this.MakeNewAppointButton.Name = "MakeNewAppointButton";
            this.MakeNewAppointButton.Size = new System.Drawing.Size(151, 23);
            this.MakeNewAppointButton.TabIndex = 5;
            this.MakeNewAppointButton.Text = "Make New Appointment ";
            this.MakeNewAppointButton.UseVisualStyleBackColor = true;
            this.MakeNewAppointButton.Click += new System.EventHandler(this.MakeNewAppointButton_Click);
            // 
            // CheckAvailability
            // 
            this.CheckAvailability.Location = new System.Drawing.Point(766, 112);
            this.CheckAvailability.Name = "CheckAvailability";
            this.CheckAvailability.Size = new System.Drawing.Size(228, 25);
            this.CheckAvailability.TabIndex = 6;
            this.CheckAvailability.Text = "Check GPs and Nurses Availability ";
            this.CheckAvailability.UseVisualStyleBackColor = true;
            this.CheckAvailability.Click += new System.EventHandler(this.CheckAvailability_Click);
            // 
            // AppointmentDataGrid
            // 
            this.AppointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDataGrid.Location = new System.Drawing.Point(12, 208);
            this.AppointmentDataGrid.Name = "AppointmentDataGrid";
            this.AppointmentDataGrid.Size = new System.Drawing.Size(801, 175);
            this.AppointmentDataGrid.TabIndex = 7;
            this.AppointmentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(833, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(863, 226);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(109, 34);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update Database";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(863, 293);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(109, 32);
            this.DeleteRowButton.TabIndex = 10;
            this.DeleteRowButton.Text = "Delete Appointment ";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(287, 182);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBox.TabIndex = 11;
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(177, 185);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 13);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Search By Date :";
            // 
            // AppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 431);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.AppointmentDataGrid);
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
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button MakeNewAppointButton;
        private System.Windows.Forms.Button CheckAvailability;
        private System.Windows.Forms.DataGridView AppointmentDataGrid;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}