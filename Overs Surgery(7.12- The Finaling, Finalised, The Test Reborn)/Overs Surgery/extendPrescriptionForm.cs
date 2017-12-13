using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Overs_Surgery
{
    public partial class ExtendPrescriptionForm : Form
    {

        SqlConnection tableconnection;
        SqlCommand updateNewDate;
        SQL_Commands querygenerator;
                                         
        public ExtendPrescriptionForm(string patient_ID)
        {
            InitializeComponent();
            PatientIDtxtBox.Text = patient_ID;
        }

        
        private void updateButton_Click(object sender, EventArgs e)
        {
            //checks if values were entered into the text box
            if (endDateSelector.Text == "")
            {
                MessageBox.Show("Please enter a new date");
            }

            else
            {
                tableconnection.Open();
                updateNewDate = new SqlCommand(querygenerator.setNewDate(PatientIDtxtBox.Text,endDateSelector.Text),tableconnection);
                updateNewDate.ExecuteNonQuery();

                MessageBox.Show("Prescription Updated");
                tableconnection.Close();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
       
        

        private void extendPrescriptionForm_Load(object sender, EventArgs e)
        {
            querygenerator = new SQL_Commands();
            tableconnection = new SqlConnection(Properties.Settings.Default.DatabaseConnection);
            
            

        }

        private void PatientIDtxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
