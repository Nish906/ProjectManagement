using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.U.N_System_BackEnd
{
    public partial class frmBookAppointment : Form
    {
        public frmBookAppointment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //if statement to make sure that text box has a value before submitting the form
            if (txtAppointmentDetails.Text == "")
            {
                lblError.Text = "Please fill in appointment details";
            }
            else
            {
                // Display a message box informing the user of there selection 
                MessageBox.Show("You are about to make an appointment. Do you want to continue?", "My Application",
                    //Displays Ok or cancel as buttons 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                //create instance of form
                frmListOfAppointments MyList = new frmListOfAppointments();
                //refresh List
                MyList.Refresh();
                //close form
                Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears anything from textboxes 
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtAppointmentDetails.Clear();
            //error message showing what has been done
            lblError.Text = "Information has been cleared";

        }

        private void frmBookAppointment_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }
    }
}
