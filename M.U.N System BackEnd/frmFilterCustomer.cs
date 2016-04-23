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
            MainMenu Customer = new MainMenu();
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

        }
    }
}
