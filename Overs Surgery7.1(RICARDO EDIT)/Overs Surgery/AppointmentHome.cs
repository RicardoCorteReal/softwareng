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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage Login2 = new LoginPage();
            Login2.Show();
        }

        private void MakeNewAppointButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAppointHome NewAppoint = new FormAppointHome();
            NewAppoint.Show();
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Home = new Thread(HomeOne);
            Home.SetApartmentState(ApartmentState.STA);
            Home.Start();

        }
        private void HomeOne(object Obj3)
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
            // TODO: This line of code loads data into the 'patientDatabaseDataSet1.Appointment_Table' table. You can move, or remove it, as needed.
            this.appointment_TableTableAdapter.Fill(this.patientDatabaseDataSet1.Appointment_Table);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //if row is selected then do this
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                //go to the new appointment page
                FormAppointHome NewAppoint = new FormAppointHome();
                NewAppoint.Show();
            }
            //if row isnt selected display this message
            else
            {
                MessageBox.Show("You have not selected a row!");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                
            }
            else
            {
                MessageBox.Show("You have not selected a row!");
            }
        }
     
    }
}
