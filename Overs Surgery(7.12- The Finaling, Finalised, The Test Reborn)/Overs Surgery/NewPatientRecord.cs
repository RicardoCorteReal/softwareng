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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Overs_Surgery
{
    public partial class NewPatientRecord : Form
    {
        //Creating thread for returning to patient form
        Thread homeThread;
        //Sql Command for the NewPatientQuery
        SqlCommand Insert;
        //Sql Connection
        SqlConnection cn;
        //Creating an instance of the SqlCommandsClass
        SQL_Commands Command2 = new SQL_Commands();
        public NewPatientRecord()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button to return home from this form
            //Closing this form
            this.Close();
            //Using thread to return to home page
            homeThread = new Thread(GoHome);
            homeThread.SetApartmentState(ApartmentState.STA);
            homeThread.Start();

        }
        private void GoHome(object obj5)
        {
            //method for returning to main page
            Application.Run(new HomePage());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            newPatientMeth(PatientNameTextBox.Text, PatientSurnameTextBox.Text, PatientEmailTextbox.Text, PatientAddressTextbox.Text, DateofBirthSelector.Text);
        }

        private void newPatientMeth(string one, string two, string three, string four, string five)
        {
            //Linking SqlConnection to sotred datasource
            cn = new SqlConnection(Properties.Settings.Default.DatabaseConnection);
            //Opening connection
            cn.Open();
            //Using SqlCommand Class to created command with text provided by user
            Insert = new SqlCommand(Command2.SqlNewPatient, cn);
            //Passing parameters to the Sql Command
            Insert.Parameters.AddWithValue("@FirstName", one);
            Insert.Parameters.AddWithValue("@Surname", two);
            Insert.Parameters.AddWithValue("@Email", three);
            Insert.Parameters.AddWithValue("@Address", four);
            Insert.Parameters.AddWithValue("@DateOfBirth", five);
            //Executing Query on database
            Insert.ExecuteNonQuery();
            //Conformation popup
            MessageBox.Show("New Patient Record Created");
            //Closing SqlConnection
            cn.Close();
        }

        private void newPatientTest()
        {
            newPatientMeth("Name1", "Sur1", "Test1@test.com", "Test1 Street", "2017-12-08");
            newPatientMeth("Name2", "Sur2", "Test2@test.com", "Test2 Street", "2017-12-08");
            newPatientMeth("Name3", "Sur3", "Test3@test.com", "Test3 Street", "2017-12-08");
        }

        private void PatientSUrnameTextBopx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientTelephoneNUmber_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientAddressTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateOfBirthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateofBirthSelector_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NewPatientRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
