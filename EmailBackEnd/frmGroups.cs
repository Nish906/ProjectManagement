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
    public partial class frmGroups : Form
    {
        public frmGroups()
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
            /*if (lstGroups.SelectedIndex == -1)
            {
                //Displaying error message
                lblGroupError.Text = "Please select a group";
            }
            else
            {
                //Clearing the error message
                lblGroupError.Text = "";
            }*/
        }
    }
}
