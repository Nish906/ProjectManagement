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
    public partial class frmEmails : Form
    {
        public frmEmails()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmSendEmail sendEmail = new frmSendEmail();
            //show form
            sendEmail.Show();
            //Close current form
            this.Hide();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmEmailContacts emailContacts = new frmEmailContacts();
            //show form
            emailContacts.Show();
            //Close current form
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmDefault Home = new frmDefault();
            //show form
            Home.Show();
            //Close current form
            this.Hide();
        }

        private void frmEmails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ourDatabaseDataSet.tblEmail' table. You can move, or remove it, as needed.
            //this.tblEmailTableAdapter.Fill(this.ourDatabaseDataSet.tblEmail);

        }
    }
}
