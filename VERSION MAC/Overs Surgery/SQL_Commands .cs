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
    class SQL_Commands
    {

        private string sqlNewAppointment = "insert into Appointment_Table(Appointment_Date, Appointment_Status, Patient_ID, Staff_ID, Patient_Date_Of_Birth, Appointment_Comment) VALUES(@Appointment_Date, @Appointment_Status, @Patient_ID, @Staff_ID, @Patient_Date_Of_Birth, @Appointment_Comment)";
        private string sqlNewPatient = "INSERT Patient_Table VALUES (@FirstName, @Surname ,@Email ,@Address ,@DateOfBirth)";
        private string searchdate = "SELECT * From Appointment_Table WHERE Appointment_Date like'";
        private string loadPrescriptionTable = "Select * From Prescription_Table";
        private string loadPatientTable = "Select * From Patient_Table";
        private string generateAppointmentTable="SELECT * FROM Appointment_Table";


        public string findPatientPrescriptionID(string a)
        {
            string locatePrescriptionID = "SELECT * FROM Prescription_Table WHERE Prescription_Patient_ID LIKE'"+ a +"%'";
            return locatePrescriptionID;
            
        }

        public string setNewDate(string patientID ,string endDate)
        {
            string newDate = "UPDATE Prescription_Table SET EndDate ='" + endDate + "' WHERE Prescription_Patient_ID ="+ patientID;
            return newDate;
        }

        public string searchPatientTestResult(string a)
        {

             string searchTestResults= "SELECT * FROM Test_Result_Table Where Patient_ID LIKE'" + a + "%'";
            return searchTestResults;
        } 
       

        public string SearchGp( string a, string b, string c)
        {

            string search = "Select * From Availability_Table WHERE Staff_Role like'" + a + "%'"+ "AND On_Duty like'"+ b +"%'"+ "AND Date like'"+ c + "%'";
            return search;

        }

        public string searchPatientTable( string a, string b , string c)
        {

            string patientSearchQuery = "Select * From Patient_Table WHERE Patient_ID like'" + a + "%'" + "AND First_Name like'" + b + "%'" + "AND Date_Of_Birth like'" + c + "%'";
            return patientSearchQuery;
        }

        public string searchPatientinPrescriptionTable(string a)
        {
            string searchQuery = "Select * From Prescription_Table WHERE Prescription_Patient_ID like'" + a + "%'";
            return searchQuery;


        }

        public string deleteAppointment( string a)
        {
            string query = "DELETE FROM Appointment_Table WHERE Appointment_ID ='"+a+"'";
            return query;
        }

        public string SqlNewAppointment
        {
            get
            {
                return sqlNewAppointment;
            }

        }

        public string SqlNewPatient
        {
            get
            {
                return sqlNewPatient;
            }
        }


        public string Searchdate
        {
            get
            {
                return searchdate;
            }

           
        }

        public string LoadPrescriptionTable
        {
            get
            {
                return loadPrescriptionTable;
            }

          
        }

        public string LoadPatientTable
        {
            get
            {
                return loadPatientTable;
            }

          
        }

        public string GenerateAppointmentTable
        {
            get
            {
                return generateAppointmentTable;
            }

            
        }


           
        }
    }
    



        
    


