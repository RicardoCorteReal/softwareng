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
    public partial class GPNurse_AvailabilityPage : Form
    {
        SqlConnection conn;
        SqlCommand checkall;
        SqlDataAdapter Data;
        SqlCommand Search;
        string load = "Select * From Availability_Table";
        SqlDataAdapter Data2;
        Thread Return;
       
        public GPNurse_AvailabilityPage()
        {
            InitializeComponent();
        }

        private void GPNurse_AvailabilityPage_Load(object sender, EventArgs e)
        {
             
         
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\Overs Surgery(7.0)\Overs Surgery\PatientDatabase.mdf;Integrated Security=True");
            conn.Open();
            checkall = new SqlCommand(load, conn);
            checkall.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            Data = new SqlDataAdapter(checkall);
            Data.Fill(Dt);
            DatabaseDisplay.DataSource = Dt;
            conn.Close();
          
       
        }

        private void CheckAvailabilityButton_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            Search = new SqlCommand("Select * From Availability_Table WHERE Staff_Role like'" + RoleSearchBox.Text + "%'" + "AND On_Duty like'" + YesAndNoComboBox.Text + "%'" + "AND Date like '" +DateTextBox.Text+ "%'", conn);
            DataTable Searchme= new DataTable();
            Data2 = new SqlDataAdapter(Search);
            Data2.Fill(Searchme);
            DatabaseDisplay.DataSource = Searchme;
            conn.Close();

         
        }


        private void YesAndNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand Search2 = new SqlCommand("Select * From Availability_Table WHERE Staff_Role like'" + RoleSearchBox.Text + "%'" + "AND On_Duty like'" + YesAndNoComboBox.Text + "%'" + "AND Date like '" +DateTextBox.Text+ "%'", conn);
            SqlDataAdapter data3 = new SqlDataAdapter(Search2);
            DataTable Dt3 = new DataTable();
            data3.Fill(Dt3);
            DatabaseDisplay.DataSource = Dt3;
            conn.Close();

        }

        private void AppointmentPageButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Return = new Thread(ReturnBack);
            Return.SetApartmentState(ApartmentState.STA);
            Return.Start();

        }
        private void ReturnBack()
        {
            Application.Run(new AppointmentPage());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand search4 = new SqlCommand("Select * From Availability_Table WHERE Staff_Role like'" + RoleSearchBox.Text + "%'" + "AND On_Duty like'" + YesAndNoComboBox.Text + "%'" + "AND Date like '" + DateTextBox.Text + "%'", conn);
            SqlDataAdapter data4 = new SqlDataAdapter(search4);
            DataTable dt4 = new DataTable();
            data4.Fill(dt4);
            DatabaseDisplay.DataSource = dt4;
            conn.Close();
        }

        
    }
}
