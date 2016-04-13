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
    public partial class frmSendEmail : Form
    {
        public frmSendEmail()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Close current form
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Checking if text box to is empty
            if (txtTo.Text == "")
            {
                //Checking if text box subject is empty
                if (txtSubject.Text == "")
                {
                    //Checking if text box content is empty
                    if (txtContent.Text == "")
                    {
                        //If so, display error message
                        lblSendingError.Text = "Please fill in missing areas";
                    }
                }
            }
            else 
            {
                //Clearing the error message
                lblSendingError.Text = "";
                //Closing the form
                Close();
                //Displaying message the user that email has been sent
                MessageBox.Show("Email Sent", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
