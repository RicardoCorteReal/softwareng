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
using System.Runtime.InteropServices;

namespace Overs_Surgery
{

    public partial class LoginPage : Form
    {
        //Creating an instance of the UserInfo Class
        UserInfo Use = new UserInfo();
        
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
            login(textBox2.Text, textBox1.Text);
        }

        private void login(string userName, string userPass)
        {
            //Christian Login If textbox2(username) equals to Christian then it works
            if (string.Compare(userName, Use.U1useName, true) == 0)
            {

                //if textbox1(password) equals one then it logs in
                if (userPass == Use.U1Pass)
                {
                    this.Close();
                    one = new Thread(Home);
                    one.SetApartmentState(ApartmentState.STA);
                    one.Start();

                }
            }

            //Ricardo Login
            else if (string.Compare(userName, Use.U2useName, true) == 0)
            {


                if (userPass == Use.U2Pass)
                {
                    this.Close();
                    one = new Thread(Home);
                    one.SetApartmentState(ApartmentState.STA);
                    one.Start();

                }


            }
            //Nial Login
            if (string.Compare(userName, Use.U3useName, true) == 0)
            {


                if (userPass == Use.U3Pass)
                {
                    this.Close();
                    one = new Thread(Home);
                    one.SetApartmentState(ApartmentState.STA);
                    one.Start();

                }


            }
            //If password or username are incorrect then this will happen, which is basically a error message box.
            else if (userName + userPass == "")
            {
                MessageBox.Show("Please enter your details.");
            }
            else if (userName == "")
            {
                MessageBox.Show("Please enter your Username.");
            }
            else if (userPass=="")
            {
                MessageBox.Show("Please enter your Password.");
            }
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
            Application.Exit();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Testing section
        //Running the testing method by pressing the test button
        private void btn_Test_Click(object sender, EventArgs e)
        {
            //running method and passing it the user test input
                login("WrongTest", "WrongTest");
                login("WrongTest", Use.U1Pass);
                login(Use.U1useName, "WrongTest");
                login("", Use.U1Pass);
                login(Use.U1useName, "");
                login("", "");
                login(Use.U1useName,Use.U1Pass);
        }
    }
}