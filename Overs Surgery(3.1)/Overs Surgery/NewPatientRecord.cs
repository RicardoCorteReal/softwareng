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
        Thread homeThread;
        SqlCommand Insert;
        SqlConnection cn;
        SqlDataAdapter da;
        public NewPatientRecord()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            homeThread = new Thread(GoHome);
            homeThread.SetApartmentState(ApartmentState.STA);
            homeThread.Start();

        }
        private void GoHome(object obj5)
        {
            Application.Run(new HomePage());

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\Uni Files\2nd Year\Software Engineering\Planning Files\Program Files\Overs Surgery(7.0)\Overs Surgery\PatientDatabase.mdf;Integrated Security=True");
            cn.Open();
            Insert = new SqlCommand("INSERT INTO Patient_Table VALUES ( @FirstName , @Surname , @Email , @Address , @DateOfBirth)", cn);
            Insert.Parameters.AddWithValue("@FirstName", PatientNameTextBox.Text);
            Insert.Parameters.AddWithValue("@Surname", PatientSurnameTextBox.Text);
            Insert.Parameters.AddWithValue("@Email", PatientEmailTextbox.Text);
            Insert.Parameters.AddWithValue("@Address", PatientAddressTextbox.Text);
            Insert.Parameters.AddWithValue("@DateOfBirth", DateofBirthSelector.Text);
            Insert.ExecuteNonQuery();
            MessageBox.Show("New Patient Record Created");
            cn.Close();
            


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
    }
}
