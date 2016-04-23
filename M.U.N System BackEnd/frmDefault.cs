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
    public partial class frmDefault : Form
    {
        public frmDefault()
        {
            InitializeComponent();
        }

        private void btnEmails_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmEmails Emails = new frmEmails();
            //show form
            Emails.Show();
            //Close current form
            this.Hide();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmAppointments Appointments = new frmAppointments();
            //show form
            Appointments.Show();
            //Close current form
            this.Hide();
        }
    }
}
