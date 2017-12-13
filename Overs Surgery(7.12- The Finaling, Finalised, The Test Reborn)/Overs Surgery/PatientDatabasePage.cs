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
using System.Data.SqlClient;

namespace Overs_Surgery
{
    public partial class PatientDatabasePage : Form
    {
        
        SqlCommand retrievePrecriptionDetails;
        SQL_Commands queryManager;
        Thread NewPatient;
        SqlConnection connection;
        SqlCommand checkAll;
        SqlCommand loadPrescription;
        SqlCommand printResults;
        SqlDataAdapter Data;
        SqlCommand Search;
        SqlCommand Search2;
        SqlCommand Search3;
        SqlCommand Search4;
        SqlDataAdapter Data2;
        SqlDataAdapter Data3;
        SqlDataAdapter Data4;
        SqlDataAdapter Data5;
        SqlDataAdapter Data6;
        SqlDataReader tableReader;
        Thread Home;
        ExtendPrescriptionForm newDate;

        public PatientDatabasePage()
        {
            InitializeComponent();
        }
        private void Create()
        {
            Application.Run(new NewPatientRecord());

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            //Closing the current form
            this.Close();
            //Using a new thread to open newPatientRecord to conserve memory
            NewPatient = new Thread(Create);
            NewPatient.SetApartmentState(ApartmentState.STA);
            NewPatient.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientDatabasePage_Load(object sender, EventArgs e)
        {

            queryManager = new SQL_Commands();
            connection = new SqlConnection(Properties.Settings.Default.DatabaseConnection);
            connection.Open();
            checkAll = new SqlCommand(queryManager.LoadPatientTable, connection);
            checkAll.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            Data = new SqlDataAdapter(checkAll);
            Data.Fill(Dt);
            PatienceDataGridView.DataSource = Dt;
            


            connection.Close();

            //Opens connection to the presecription table and fils the data grid
            connection.Open();
            loadPrescription = new SqlCommand(queryManager.LoadPrescriptionTable, connection);
            loadPrescription.ExecuteNonQuery();
            DataTable prescriptionTable = new DataTable();
            Data6 = new SqlDataAdapter(loadPrescription);
            Data6.Fill(prescriptionTable);
            PrescriptionDataGridView.DataSource = prescriptionTable;
            connection.Close();


            
        }

        private void txtBxPatientID_TextChanged_1(object sender, EventArgs e)
        {
            // Searches the Patient Table 
            connection.Open();
            Search = new SqlCommand(queryManager.searchPatientTable(txtBxPatientID.Text,txtBxPatientName.Text, txtBxDob.Text), connection);
            DataTable dt2 = new DataTable();
            Data2 = new SqlDataAdapter(Search);
            Data2.Fill(dt2);
            PatienceDataGridView.DataSource = dt2;
            connection.Close();

            //Searches for patient in prescription table 
            connection.Open();
            Search4 = new SqlCommand(queryManager.searchPatientinPrescriptionTable(txtBxPatientID.Text), connection);
            DataTable dt5 =new DataTable();
            Data5 = new SqlDataAdapter(Search4);
            Data5.Fill(dt5);
            PrescriptionDataGridView.DataSource = dt5;
            connection.Close();

            
            
           
            
        }

        private void txtBxDob_TextChanged(object sender, EventArgs e)
        {

            //SQL Code searches and cheacks all three check boxes 
            connection.Open();
            Search2 = new SqlCommand(queryManager.searchPatientTable(txtBxPatientID.Text, txtBxPatientName.Text, txtBxDob.Text), connection);
            DataTable dt3 = new DataTable();
            Data3 = new SqlDataAdapter(Search2);
            Data3.Fill(dt3);
            PatienceDataGridView.DataSource = dt3;
            connection.Close();
        }

        private void txtBxPatientName_TextChanged(object sender, EventArgs e)
        {//SQL Code searches and cheacks all three check boxes 
            connection.Open();
            Search3 = new SqlCommand(queryManager.searchPatientTable(txtBxPatientID.Text, txtBxPatientName.Text, txtBxDob.Text), connection);
            DataTable dt4 = new DataTable();
            Data4 = new SqlDataAdapter(Search3);
            Data4.Fill(dt4);
            PatienceDataGridView.DataSource = dt4;
            connection.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Home = new Thread(goHome);
            Home.SetApartmentState(ApartmentState.STA);
            Home.Start();

        }

        private void goHome()
        {
            Application.Run(new HomePage());

        }

        private void PrintPatientResult_Click(object sender, EventArgs e)
        {   //Checks if the value is empty;shows error message if it does
            if ( txtBxPatientID.Text=="")
            {
                MessageBox.Show("Please enter a patient ID");

            }

            else
            {
                PrintDialogButton.Document = PrintDoumentButton;
                if (PrintDialogButton.ShowDialog() == DialogResult.OK)
                {
                    PrintDoumentButton.Print();
                }
                


            }
        }

        private void PrintDoumentButton_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {// Prints out the patient's test results 
            connection.Open();
            //Sets the SQL command 
            printResults = new SqlCommand(queryManager.searchPatientTestResult(txtBxPatientID.Text),connection);
            // Sets the Datareader to the sqlcommand
            tableReader = printResults.ExecuteReader();
            //If statement checks if the reader is able to read the table
            if (tableReader.Read())
            {
                //retrieves each column speciefied in the sql statement and draws
                e.Graphics.DrawString("Test ID:" + tableReader[0].ToString(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, 25, 50);
                e.Graphics.DrawString("Patient ID:" + tableReader[1].ToString(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, 25, 100);
                e.Graphics.DrawString("Patient Test Results are:" + tableReader[2].ToString(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, 25, 150);
                e.Graphics.DrawString("GP/Nurse Comments:" + tableReader[3].ToString(), new Font("Arial", 17, FontStyle.Bold), Brushes.Black,25, 200);
                tableReader.Close();
                connection.Close();
            }


            
        }

        private void ExtendPatientPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (txtBxPatientID.Text =="")
            {
                MessageBox.Show("Please enter a patient ID in the corresponding text box!");

            }
            else { 
            connection.Open();
            retrievePrecriptionDetails = new SqlCommand(queryManager.findPatientPrescriptionID(txtBxPatientID.Text), connection);
            tableReader = retrievePrecriptionDetails.ExecuteReader();
                if (tableReader.Read())
                {
                    var extendpop = newDate = new ExtendPrescriptionForm(tableReader[4].ToString());
                    extendpop.ShowDialog();
                    connection.Close();
                    tableReader.Close();
                }
                else
                {
                    MessageBox.Show("The patient ID doesn't exist");
                }
            }
           
        }

        private void RefreshBustton_Click(object sender, EventArgs e)
        {

        }
    }
}
