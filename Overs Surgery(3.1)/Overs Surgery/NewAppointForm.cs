using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Overs_Surgery;
using System.Threading;
using System.Data.SqlClient;


namespace UI_Appoinment
{
    public partial class FormAppointHome : Form
    {
        Thread GoHome;
        SqlDataAdapter theAdapter;
        SqlConnection theConnection;
        SqlCommand insertData;
        string insertCommand = "INSERT ";
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
            GoHome = new Thread(ReturnToAppointment);
            GoHome.SetApartmentState(ApartmentState.STA);
            GoHome.Start();
            
               
        }
         private void ReturnToAppointment()
        {
            Application.Run(new AppointmentPage());

        }

        private void ButtonAppointSubmit_Click_1(object sender, EventArgs e)
        {
            theConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = K:\Overs Surgery(7.0)\Overs Surgery\PatientDatabase.mdf; Integrated Security = True");
            theConnection.Open();
            insertData = new SqlCommand("INSERT INTO Appointment_Table VALUES(@FirstName, @Surname, @Email, @Address, @DateOfBirth");
        }

        private void ListBoxGPs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelAppointPatientName_Click(object sender, EventArgs e)
        {

        }

        private void LabelAppointGPName_Click(object sender, EventArgs e)
        {

        }
    }
}
