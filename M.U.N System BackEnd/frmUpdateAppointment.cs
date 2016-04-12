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
    public partial class frmUpdateAppointment : Form
    {
        public frmUpdateAppointment()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Display a message box informing the user of there selection 
            MessageBox.Show("You are about to update appointment?", "My Application",
            //Displays Ok or cancel as buttons 
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //create instance of form
            frmListOfAppointments MyList = new frmListOfAppointments();
            //refresh List
            MyList.Refresh();
            //close form
            Close();
        }

        private void btncClose_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }
    }
}
 