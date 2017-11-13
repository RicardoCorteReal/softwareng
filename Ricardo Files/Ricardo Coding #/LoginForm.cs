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
        // Creates and controls the following threads.
        Thread one;

        // Method to give access and initialize the component LoginPage
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
        
        // This is where the password and login is checked 
        private void button1_Click(object sender, EventArgs e)
        {
           /*Christian Login
            * If textbox2(username) equals to Christian then it works
           */
            if (string.Compare( textBox2.Text ,"Christian", true) == 0)
            {
              
                //if textbox1(password) equals one then it logs in
                if ( textBox1.Text == "one")
                {
                    this.Close();
                    one = new Thread(Home);
                    one.SetApartmentState(ApartmentState.STA);
                    one.Start();

                }
            }
           
            //Ricardo Login
            else if (string.Compare(textBox2.Text, "Ricardo", true) == 0)
            {


                if (textBox1.Text == "two")
                {
                    this.Close();
                    one = new Thread(Home);
                    one.SetApartmentState(ApartmentState.STA);
                    one.Start();

                }


            }
            //Nial Login
            if (string.Compare(textBox2.Text, "Niall", true) == 0)
            {


                if (textBox1.Text == "three")
                {
                    this.Close();
                    one = new Thread(Home);
                    one.SetApartmentState(ApartmentState.STA);
                    one.Start();

                }


            }
            //If password or username are incorrect then this will happen, which is basically a error message box.
            else
            {
                MessageBox.Show("Your details are incorrect, please try again.");

            }
        }

        // This connects to the HomePage form so it goes automatically to it.
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
