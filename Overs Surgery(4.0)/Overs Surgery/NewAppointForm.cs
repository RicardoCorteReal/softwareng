﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Overs_Surgery;

namespace UI_Appoinment
{
    public partial class FormAppointHome : Form
    {
        public FormAppointHome()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ButtonAppointSubmit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentPage Appoint2 = new AppointmentPage();
            Appoint2.Show();
            
           
            
            
        }

        private void ButtonAppointSubmit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
