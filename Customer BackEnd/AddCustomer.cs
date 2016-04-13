using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenDesignsWindowsForm
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the form
            Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
            {
                if (txtFirstName.Text == "")
                {
                    if (txtLastName.Text == "")
                    {
                        if (txtCity.Text == "")
                        {
                            if (txtPostCode.Text == "")
                            {
                                if (txtPhoneNo.Text == "")
                                {
                                    if (txtEmailAdd.Text == "")
                                    {
                                        lblError.Text = "Please fill in missing details.";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                lblError.Text = "";
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
