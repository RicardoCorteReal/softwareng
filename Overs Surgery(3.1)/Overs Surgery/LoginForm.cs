using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Overs_Surgery
{
    public partial class LoginPage : Form
    {
        Thread one;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.Compare( textBox2.Text ,"Christian", true) == 0)
            {
              

                if ( textBox1.Text == "one")
                {
                    this.Close();
                    one = new Thread(Home);
                    one.SetApartmentState(ApartmentState.STA);
                    one.Start();

                }

                
            }
            else
            {
                MessageBox.Show("Your details are incorrect, please try again.");

            }


        }
        private void Home(object obj1)
        {
          Application.Run(new HomePage());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
