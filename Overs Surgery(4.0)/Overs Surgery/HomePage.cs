using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Overs_Surgery
{
    public partial class HomePage : Form
    {
        Thread LogoutButton;
        Thread AppointmentPage;
        Thread PatientDatabase;
        public HomePage()
        {
            InitializeComponent();
        }

        private void AppointmentPageButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentPage = new Thread(GoToAppointment);
            AppointmentPage.SetApartmentState(ApartmentState.STA);
            AppointmentPage.Start();
        }

        private void GoToAppointment(object obj6)
        {
            Application.Run(new AppointmentPage());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
            LogoutButton = new Thread(Logout);
            LogoutButton.SetApartmentState(ApartmentState.STA);
            LogoutButton.Start();
        }
        private void Logout( object obj2)
        {
            Application.Run( new LoginPage());

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientDatabase = new Thread(PatientDBD);
            PatientDatabase.SetApartmentState(ApartmentState.STA);
            PatientDatabase.Start();
        }

        private void PatientDBD(object obj7)
        {
            Application.Run(new patientDatabasePage
                ());
        }
    }
}
