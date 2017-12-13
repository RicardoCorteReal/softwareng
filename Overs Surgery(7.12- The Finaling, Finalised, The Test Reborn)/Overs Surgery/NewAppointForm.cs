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
using Overs_Surgery.Properties;


namespace UI_Appoinment
{
    public partial class FormAppointHome : Form
    {
        //Threading for inscresed proformance
        Thread GoHome;
        //Creating Sql adaper
        SqlDataAdapter theAdapter;
        //Creating Sql Connection
        SqlConnection theConnection;
        //Sql Command
        SqlCommand insertData;
        //New instance of sql_Command storadge class
        SQL_Commands commandOne = new SQL_Commands();
        //String to hold defaulol booking status
        private string bookingStatus = "Booked";

        //Form on load statment
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

        //On button click form is closed new thread runs the appointment page
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
            GoHome = new Thread(ReturnToAppointment);
            GoHome.SetApartmentState(ApartmentState.STA);
            GoHome.Start();
            
               
        }

        //Method for new thread
         private void ReturnToAppointment()
        {
            Application.Run(new AppointmentPage());

        }

        //On click submit button
        private void ButtonAppointSubmit_Click_1(object sender, EventArgs e)
        {
            InsertDB(AppointDateTime.Text, PatientComboBox.Text, GpNurseComboBox.Text, PatientdateOfBirthTextBox.Text, bookingStatus, RichTextBoxPatientComments.Text);
        }

        private void InsertDB(string appointDate,string paitent, string gpNurse, string pDob, string status, string comment)
        {
            //Establishing the Connection to the file destiantion
            theConnection = new SqlConnection(Overs_Surgery.Properties.Settings.Default.DatabaseConnection);

            //Opening the Sql Connection
            theConnection.Open();
            //using the command stored in the commandOne Class
            insertData = new SqlCommand(commandOne.SqlNewAppointment, theConnection);
            //Inserting to specific coloums in the Database table
            insertData.Parameters.AddWithValue("@Appointment_Date", appointDate);
            insertData.Parameters.AddWithValue("@Patient_ID", paitent);
            insertData.Parameters.AddWithValue("@Staff_ID", gpNurse);
            insertData.Parameters.AddWithValue("@Patient_Date_Of_Birth", pDob);
            insertData.Parameters.AddWithValue("@Appointment_Status", status);
            insertData.Parameters.AddWithValue("@Appointment_Comment", comment);
            //Running Query without return information
            insertData.ExecuteNonQuery();
            //Using the adaper with the command we have created
            theAdapter = new SqlDataAdapter(insertData);
            //Closing Sql connection 
            theConnection.Close();
            //Show confirmation message to user
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

        private void FormAppointHome_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            try
            {
                InsertDB("2017-12-08", "1", "1", "2017-12-08", "Test", "Test1");
                InsertDB("2017-12-08", "1", "2", "2017-12-08", "Test", "Test2");
                InsertDB("2017-12-08", "1", "3", "2017-12-08", "Test", "Test3");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
