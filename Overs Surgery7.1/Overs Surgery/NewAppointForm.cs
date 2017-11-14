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
        string bookingStatus = "Booked";
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
            theConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\Overs Surgery7.1\Overs Surgery\PatientDatabase.mdf;Integrated Security=True");
            theConnection.Open();
            insertData = new SqlCommand("INSERT INTO Appointment_Table(Appointment_Date,Appointment_Status,Patient_ID, Staff_ID, Patient_Date_Of_Birth, Appointment_Comment) VALUES (@Appointment_Date, @Appointment_Status, @Patient_ID, @Staff_ID, @Patient_Date_Of_Birth, @Appointment_Comment)", theConnection);
            insertData.Parameters.AddWithValue("@Appointment_Date", AppointDateTime.Text);
            insertData.Parameters.AddWithValue("@Patient_ID", PatientComboBox.Text);
            insertData.Parameters.AddWithValue("@Staff_ID",GpNurseComboBox.Text);
            insertData.Parameters.AddWithValue("@Patient_Date_Of_Birth", PatientdateOfBirthTextBox.Text);
            insertData.Parameters.AddWithValue("@Appointment_Status", bookingStatus);
            insertData.Parameters.AddWithValue("@Appointment_Comment",RichTextBoxPatientComments.Text);
            insertData.ExecuteNonQuery();
            theConnection.Close();
            MessageBox.Show("Appointment Created!");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GpNurseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientdateOfBirthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBoxPatientComments_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
