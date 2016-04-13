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
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Close current form
            Close();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //Checking if combo box item has been selected
            /*if (lstContacts.SelectedIndex == -1)
            {
                //Displaying error message
                lblContactError.Text = "Please select a contact";
            }
            else
            {
                //Clearing the error message
                lblContactError.Text = "";
            }*/
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emailDatabaseDataSet.EmailAddresses' table. You can move, or remove it, as needed.
            this.emailAddressesTableAdapter.Fill(this.emailDatabaseDataSet.EmailAddresses);

        }
    }
}
