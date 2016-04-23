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
    public partial class frmFilterPayment : Form
    {
        public frmFilterPayment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the current form

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Go back to the home page
            MainMenu Customer = new MainMenu();
            Customer.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display user information
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {

        }

        private void FilterPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
