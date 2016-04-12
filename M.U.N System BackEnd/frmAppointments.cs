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
    public partial class frmAppointments : Form
    {
        public frmAppointments()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmAddAppointments AddAppointments = new frmAddAppointments();
            //show form
            AddAppointments.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmReviewDetails ReviewAppointments = new frmReviewDetails();
            //show form
            ReviewAppointments.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListAppointments_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmListOfAppointments ListAppointments = new frmListOfAppointments();
            //show form
            ListAppointments.Show();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmBookAppointment BookAppointments = new frmBookAppointment();
            //show form
            BookAppointments.Show();
        }
    }
}
