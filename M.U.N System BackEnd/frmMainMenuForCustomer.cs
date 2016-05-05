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
    public partial class frmMainMenuForCustomer : Form
    {
        public frmMainMenuForCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Add filter payment button
            frmFilterPayment Customer = new frmFilterPayment();
            Customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add update customer button
            frmUpdateCustomer Customer = new frmUpdateCustomer();
            Customer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Add Filter customer button
            frmFilterCustomer Customer = new frmFilterCustomer
();
            Customer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Add find customer button
            frmFindCustomer Customer = new frmFindCustomer();
            Customer.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Close current form
            Close();
        }

        private void MainMenuForCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Add customer button
           // frmPartedPayments Customer = new frmPartedPayments();
          //  Customer.Show();
        }

        private void btnFilterPayments_Click(object sender, EventArgs e)
        {
            //Add filter payment button
            frmFilterPayment Customer = new frmFilterPayment();
            Customer.Show();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //Add update customer button
            frmUpdateCustomer Customer = new frmUpdateCustomer();
            Customer.Show();
        }

        private void btnFilterCustomer_Click(object sender, EventArgs e)
        {
            //Add Filter customer button
            frmFilterCustomer Customer = new frmFilterCustomer
();
            Customer.Show();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            //Add find customer button
            frmFindCustomer Customer = new frmFindCustomer();
            Customer.Show();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            //Close current form
            Close();
        }
    }
}
