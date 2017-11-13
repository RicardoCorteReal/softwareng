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

namespace Overs_Surgery
{
    public partial class patientDatabasePage : Form
    {
        Thread NewPatient;

        public patientDatabasePage()
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
    }
}
