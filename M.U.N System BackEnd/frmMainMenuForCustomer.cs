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
    public partial class MainMenuForCustomer : Form
    {
        public MainMenuForCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add customer button
            AddCustomer Customer = new AddCustomer();
            Customer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Add filter payment button
            FilterPayment Customer = new FilterPayment();
            Customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add update customer button
            UpdateCustomer Customer = new UpdateCustomer();
            Customer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Add Filter customer button
            FilterCustomer Customer = new FilterCustomer
();
            Customer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Add find customer button
            FindCustomer Customer = new FindCustomer();
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
    }
}
