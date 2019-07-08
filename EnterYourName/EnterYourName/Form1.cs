using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterYourName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void cmdGo_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text; // console readline
            string lastName = txtLastName.Text;
            lblResult.Text = firstName + lastName + " is an awful name. You should be embarassed."; // console writeline
            cmdGo.Text = "";
            cmdGo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGo.BackgroundImage = Properties.Resources.bomb;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            string age = txtAge.Text;
            int age1 = 0;
            try
            {
                age1 = int.Parse(age);
            }
            catch
            {
                return;
            }
            if (age1 < 18)
            {
                lblAgeAlert.Text = "You are not authorized!";
                lblAgeAlert.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                lblAgeAlert.Text = "";
            }
            if (age1 > 130)
            {
                lblAgeAlert.Text = "You are not human!";
                lblAgeAlert.ForeColor = Color.FromArgb(0, 255, 0);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmdGo.Text = "Go";
            cmdGo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGo.BackgroundImage = null;

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            lblResult.Text = "";
            lblAgeAlert.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int month = rand.Next(1, 13); // creates a number between 1 and 12
            int dice = rand.Next(1, 7);   // creates a number between 1 and 6
            int card = rand.Next(52);     // creates a number between 0 and 51
        }
    }
}
