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
    public partial class NewPatientRecord : Form
    {
        Thread homeThread;
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
    }
}
