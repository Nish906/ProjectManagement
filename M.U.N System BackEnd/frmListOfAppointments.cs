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
    public partial class frmListOfAppointments : Form
    {
        public frmListOfAppointments()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmAddAppointments AddAppointments = new frmAddAppointments();
            //show form
            AddAppointments.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Display a message box informing the user of there selection 
            MessageBox.Show("Are you sure you want to delete", "My Application",
                //Displays Ok or cancel as buttons 
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //close form
            Close();
            //create instance of form
            frmListOfAppointments MyList = new frmListOfAppointments();
            //refresh List
            MyList.Refresh();
            //re-opens form
            MyList.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmUpdateAppointment UpdateAppointment = new frmUpdateAppointment();
            //show form
            UpdateAppointment.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmBookAppointment BookAppointment = new frmBookAppointment();
            //show form
            BookAppointment.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }

        private void frmListOfAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appointment_ListOfAppointments.tblAppointments' table. You can move, or remove it, as needed.
            this.tblAppointmentsTableAdapter.Fill(this.appointment_ListOfAppointments.tblAppointments);

        }
    }
}
