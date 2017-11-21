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
        Thread NewPatient;
        SqlConnection connection;
        SqlConnection medConn;
        SqlCommand checkAll;
        SqlCommand loadPrescription;
        SqlDataAdapter Data;
        SqlCommand Search;
        SqlCommand Search2;
        SqlCommand Search3;
        SqlCommand Search4;
        SqlCommand Search5;
        string load = "Select * From Patient_Table";
        string load2 = "Select * From Prescription_Table";
        SqlDataAdapter Data2;
        SqlDataAdapter Data3;
        SqlDataAdapter Data4;
        SqlDataAdapter Data5;
        SqlDataAdapter Data6;
        SqlDataAdapter Data7;

        Thread Home;

        public PatientDatabasePage()
        {
            InitializeComponent();
        }
        private void Create()
        {
            Application.Run(new NewPatientRecord());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\Overs Surgery(7.4)\Overs Surgery\PatientDatabase.mdf;Integrated Security=True");
            connection.Open();
            checkAll = new SqlCommand(load, connection);
            checkAll.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            Data = new SqlDataAdapter(checkAll);
            Data.Fill(Dt);
            dataGridView1.DataSource = Dt;
            connection.Close();

            //Opens connection to the presecription table and fils the data grid
            connection.Open();
            loadPrescription = new SqlCommand(load2, connection);
            loadPrescription.ExecuteNonQuery();
            DataTable prescriptionTable = new DataTable();
            Data6 = new SqlDataAdapter(loadPrescription);
            Data6.Fill(prescriptionTable);
            dataGridView2.DataSource = prescriptionTable;
            connection.Close();


            
        }

        private void txtBxPatientID_TextChanged_1(object sender, EventArgs e)
        {
            // Searches the Patient Table 
            connection.Open();
            Search = new SqlCommand("Select * From Patient_Table WHERE Patient_ID like '" + txtBxPatientID.Text + "%'" + "AND First_Name like '" + txtBxPatientName.Text + "%'" + "AND Date_Of_Birth like'" + txtBxDob.Text + "%'", connection);
            DataTable dt2 = new DataTable();
            Data2 = new SqlDataAdapter(Search);
            Data2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connection.Close();

            //Searches for patient in prescription table 
            connection.Open();
            Search4 = new SqlCommand("Select * From Prescription_Table WHERE Prescription_Patient_ID like'" + txtBxPatientID.Text+ "%'", connection);
            DataTable dt5 =new DataTable();
            Data5 = new SqlDataAdapter(Search4);
            Data5.Fill(dt5);
            dataGridView2.DataSource = dt5;
            connection.Close();

            connection.Open();
            Search5 = new SqlCommand("Select * From Test_Result_Table WHERE Patient_ID like'" + txtBxPatientID.Text + "%'", connection);
            DataTable dt6 = new DataTable();
            Data7 = new SqlDataAdapter(Search5);
            Data7.Fill(dt6);
            dgvTestRes.DataSource = dt6;
            connection.Close();



        }

        private void txtBxDob_TextChanged(object sender, EventArgs e)
        {

            //SQL Code searches and cheacks all three check boxes 
            connection.Open();
            Search2 = new SqlCommand("Select * From Patient_Table WHERE Patient_ID like '" + txtBxPatientID.Text + "%'" + "AND First_Name like '" + txtBxPatientName.Text + "%'" + "AND Date_Of_Birth like'" + txtBxDob.Text + "%'", connection);
            DataTable dt3 = new DataTable();
            Data3 = new SqlDataAdapter(Search2);
            Data3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            connection.Close();
        }

        private void txtBxPatientName_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            Search3 = new SqlCommand("Select * From Patient_Table WHERE First_Name like '" + txtBxPatientName.Text + "%'" + "AND Date_Of_Birth like '" + txtBxDob.Text + "%'", connection);
            DataTable dt4 = new DataTable();
            Data4 = new SqlDataAdapter(Search3);
            Data4.Fill(dt4);
            dataGridView1.DataSource = dt4;
            connection.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Home = new Thread(GoHome);
            Home.SetApartmentState(ApartmentState.STA);
            Home.Start();

        }

        private void GoHome()
        {
            Application.Run(new HomePage());

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
