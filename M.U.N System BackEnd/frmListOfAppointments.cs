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
    public partial class frmListOfAppointments : Form
    {
        public frmListOfAppointments()
        {
            InitializeComponent();
        }

        private void frmListOfAppointments_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmAddAppointments AddAppointments = new frmAddAppointments();
            //show form
            AddAppointments.Show();
        }

        public static class LoginInfo
        {
            public static string AppointmentID;
        }

        private void frmListOfAppointments_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ourDatabaseDataSet.tblAppointment' table. You can move, or remove it, as needed.
            //this.tblAppointmentTableAdapter.Fill(this.ourDatabaseDataSet.tblAppointment);
            


        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //create instance of form
            frmUpdateAppointment UpdateAppointment = new frmUpdateAppointment();
            //show form
            UpdateAppointment.Show();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            clsAppointmentCollection delete = new clsAppointmentCollection();
            delete.Delete();
            this.Hide();
            frmListOfAppointments form = new frmListOfAppointments();
            form.Show();
            this.Close();

            //// Display a message box informing the user of there selection 
            //MessageBox.Show("Are you sure you want to delete", "My Application",
            //    //Displays Ok or cancel as buttons 
            //MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            ////close form
            //Close();
            ////create instance of form
            //frmListOfAppointments MyList = new frmListOfAppointments();
            ////refresh List
            //MyList.Refresh();
            ////re-opens form
            //MyList.Show();
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            //create instance of form
            frmBookAppointment BookAppointment = new frmBookAppointment();
            //show form
            BookAppointment.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            //close form
            Close();
        }


        public void Finish(DateTime AppointmentDate, int SelectedIndex)
        {
            lstAppointments.Items.RemoveAt(SelectedIndex);
            string EditListBox = "AppointmentDate" + AppointmentDate;
            lstAppointments.Items.Add(EditListBox);
        }

        public void AddNewAppointment(DateTime AppointmentDate)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("AppointmentDate", AppointmentDate);
            DB.Execute("sproc_tblAppointment_Insert");
        }

        private void dataGridAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
