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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Click on here to go to all buttons to link to the customer information
            MainMenuForCustomer Customer = new MainMenuForCustomer();
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
    }
}
