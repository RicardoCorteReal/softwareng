using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Appoinment;
using System.Threading;
using System.Data.SqlClient;

namespace Overs_Surgery
{
    public partial class AppointmentPage : Form
    {
        Thread Home;
        Thread Availability;
        SqlConnection TheConnection;
        Thread newAppointment;
        SQL_Commands commandList = new SQL_Commands();
        string connection = Properties.Settings.Default.DatabaseConnection;
        SqlCommand LoadAppointment;
        SqlCommand searchdates;
        
        
        public AppointmentPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void MakeNewAppointButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newAppointment.Start();
        }

        private void newAppointmentForm()
        {
            Application.Run( new FormAppointHome ());

        }
        private void HomePageButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Home = new Thread(HomeOne);
            Home.SetApartmentState(ApartmentState.STA);
            Home.Start();

        }
        private void HomeOne( object Obj3)
        {
            Application.Run(new HomePage());

        }

        private void Check(object Obj3)
        {
            Application.Run(new GPNurse_AvailabilityPage());

        }

        private void CheckAvailability_Click(object sender, EventArgs e)
        {
            this.Close();
            Availability = new Thread(Check);
            Availability.SetApartmentState(ApartmentState.STA);
            Availability.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void AppointmentPage_Load(object sender, EventArgs e)
        {

            TheConnection = new SqlConnection(connection);
            TheConnection.Open();
            LoadAppointment = new SqlCommand(commandList.GenerateAppointmentTable, TheConnection);
            LoadAppointment.ExecuteNonQuery();
            SqlDataAdapter DaAdapter = new SqlDataAdapter(LoadAppointment);
            DataTable DaTable = new DataTable();
            DaAdapter.Fill(DaTable);
            AppointmentDataGrid.DataSource = DaTable;
            TheConnection.Close();
            newAppointment = new Thread(newAppointmentForm);
            newAppointment.SetApartmentState(ApartmentState.STA);
            


        }


         

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (AppointmentDataGrid.SelectedRows.Count != 0)
            {//Selects the row and deletes it if the user wishes 
                TheConnection.Open();
                int selectedIndex = AppointmentDataGrid.SelectedRows[0].Index;
                int row = int.Parse(AppointmentDataGrid[0,selectedIndex].Value.ToString());
                //SQl command class used excute the SQL query 
                SqlCommand DeleteRow2 = new SqlCommand(commandList.deleteAppointment(row.ToString()), TheConnection);
                SqlDataAdapter adapter3 = new SqlDataAdapter(DeleteRow2);
                DeleteRow2.ExecuteNonQuery();
                TheConnection.Close();
                this.Close();
                newAppointment.Start();

            }
            else
            {
                MessageBox.Show("Please select a row");


            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if(AppointmentDataGrid.SelectedRows.Count != 0)
            {
                TheConnection.Open();
                int selectedIndex = AppointmentDataGrid.SelectedRows[0].Index;
                int row = int.Parse(AppointmentDataGrid[0, selectedIndex].Value.ToString());
                SqlCommand DeleteRow = new SqlCommand(commandList.deleteAppointment(row.ToString()), TheConnection);
                SqlDataAdapter adapter2 = new SqlDataAdapter(DeleteRow);
             
                AppointmentDataGrid.Rows.RemoveAt(this.AppointmentDataGrid.SelectedRows[0].Index);
                DeleteRow.ExecuteNonQuery();
                TheConnection.Close();


                 

            }
            else
            {
                MessageBox.Show("Please select a row");


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TheConnection.Open();
            searchdates = new SqlCommand(commandList.Searchdate + SearchBox.Text + "%'", TheConnection);
            DataTable searchdateTable = new DataTable();
            SqlDataAdapter adapter3 =new SqlDataAdapter(searchdates);
            adapter3.Fill(searchdateTable);
            AppointmentDataGrid.DataSource = searchdateTable;
            TheConnection.Close();
            


        }
    }
}
