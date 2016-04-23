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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Click on here to go to all buttons to link to the customer information
            frmMainMenuForCustomer Customer = new frmMainMenuForCustomer();
            Customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Click on here to go to all buttons to link to the Appointment information
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Click on here to go to all buttons to link to the Payment information
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
