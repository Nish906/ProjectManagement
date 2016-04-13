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
    public partial class FindCustomer : Form
    {
        public FindCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the current form

            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Display user information when searched
        }
    }
}
