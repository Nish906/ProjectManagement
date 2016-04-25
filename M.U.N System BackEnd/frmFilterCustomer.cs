using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace M.U.N_System_BackEnd
{
    public partial class frmFilterCustomer : Form
    {
        public frmFilterCustomer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //close the form

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Go back to the Home page
            frmMainMenuForCustomer Customer = new frmMainMenuForCustomer();
            Customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete user detail from the list
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Archive the user detail
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display user Info
        }

        private void FilterCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ourDatabaseDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.ourDatabaseDataSet.tblCustomer);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 CustomerID;

            if (lstFilter.SelectedIndex != -1)
            {
                CustomerID = Convert.ToInt32(lstFilter.SelectedValue);
                //Create an instance of an order
                clsCustomerCollection customer = new clsCustomerCollection();
                //Find the record to cancel
                customer.ThisCustomer.Find(CustomerID);
                customer.Delete();
            }
            else
            {
                lblFilter.Text = "Please selectr an item to delete";
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Go back to the Home page
            frmMainMenuForCustomer Customer = new frmMainMenuForCustomer();
            Customer.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //close the form

            Close();
        }
    }
}
