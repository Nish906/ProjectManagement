using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailBackEnd
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //Creating a new instance of the send email form
            frmSendEmail SendEmail = new frmSendEmail();
            //Display the new instance form
            SendEmail.Show();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            //Creating a new instance of the send email form
            frmContacts Contacts = new frmContacts();
            //Display the new instance form
            Contacts.Show();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            //Creating a new instance of the send email form
            frmGroups Groups = new frmGroups();
            //Display the new instance form
            Groups.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Checking if combo box item has been selected
            /*if (cmbFilter.SelectedIndex == -1)
            {
                //Displaying error message
                lblFilterError.Text = "Please select filter";
            }
            else
            {
                //Clearing the error message
                lblFilterError.Text = "";
            }*/
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emailDatabaseDataSet.Emails' table. You can move, or remove it, as needed.
            this.emailsTableAdapter.Fill(this.emailDatabaseDataSet.Emails);

        }
    }
}
