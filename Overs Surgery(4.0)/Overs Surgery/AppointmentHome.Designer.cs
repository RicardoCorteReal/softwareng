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
            this.HomePageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WenesdayLabel = new System.Windows.Forms.Label();
            this.MonayLable = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.MakeNewAppointButton = new System.Windows.Forms.Button();
            this.CheckAvailability = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DateTable.SuspendLayout();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // DateTable
            // 
            this.DateTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTable.ColumnCount = 7;
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.77273F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20455F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20455F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20455F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20455F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20455F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20455F));
            this.DateTable.Controls.Add(this.label5, 6, 0);
            this.DateTable.Controls.Add(this.label4, 5, 0);
            this.DateTable.Controls.Add(this.label3, 4, 0);
            this.DateTable.Controls.Add(this.label2, 3, 0);
            this.DateTable.Controls.Add(this.WenesdayLabel, 2, 0);
            this.DateTable.Controls.Add(this.MonayLable, 0, 0);
            this.DateTable.Controls.Add(this.TuesdayLabel, 1, 0);
            this.DateTable.Location = new System.Drawing.Point(216, 234);
            this.DateTable.Name = "DateTable";
            this.DateTable.RowCount = 2;
            this.DateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DateTable.Size = new System.Drawing.Size(504, 100);
            this.DateTable.TabIndex = 0;
            this.DateTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sunday ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saturday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Friday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thursday";
            // 
            // WenesdayLabel
            // 
            this.WenesdayLabel.AutoSize = true;
            this.WenesdayLabel.Location = new System.Drawing.Point(148, 0);
            this.WenesdayLabel.Name = "WenesdayLabel";
            this.WenesdayLabel.Size = new System.Drawing.Size(58, 13);
            this.WenesdayLabel.TabIndex = 7;
            this.WenesdayLabel.Text = "Wenesday";
            // 
            // MonayLable
            // 
            this.MonayLable.AutoSize = true;
            this.MonayLable.Location = new System.Drawing.Point(3, 0);
            this.MonayLable.Name = "MonayLable";
            this.MonayLable.Size = new System.Drawing.Size(45, 13);
            this.MonayLable.TabIndex = 5;
            this.MonayLable.Text = "Monday";
            this.MonayLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Location = new System.Drawing.Point(77, 0);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(48, 13);
            this.TuesdayLabel.TabIndex = 6;
            this.TuesdayLabel.Text = "Tuesday";
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
            // AppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 362);
            this.Controls.Add(this.CheckAvailability);
            this.Controls.Add(this.MakeNewAppointButton);
            this.Controls.Add(this.DateTable);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HomePageButton);
            this.Name = "AppointmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DateTable.ResumeLayout(false);
            this.DateTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel DateTable;
        private System.Windows.Forms.Label MonayLable;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WenesdayLabel;
        private System.Windows.Forms.Button MakeNewAppointButton;
        private System.Windows.Forms.Button CheckAvailability;
    }
}