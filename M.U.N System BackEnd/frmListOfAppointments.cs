﻿using System;
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
        private List<Int32> AppointmentList = new List<Int32>();

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

            DeleteAppointment();
            //this checks to see if the user has selected an item from the listbox, as the default value is -1
            //if (lstAppointments.SelectedIndex > -1)
            //{

            /////////////////////
            //    if (MessageBox.Show("Are you sure you want to delete this saved search?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        string AppointmentList = lstAppointments.SelectedIndex.ToString();
            //        DateTime AppointmentDate = Convert.ToDateTime(AppointmentList.Substring(8,2));

            //        clsAppointmentCollection Appointment = new clsAppointmentCollection();
            //        Appointment.Delete(AppointmentDate);
            //        frmListOfAppointments Form = new frmListOfAppointments();
            //        this.Close();
            //        Form.Show();
                    

            //    }

            }
        ///////////
            //else
            //{
            //    //this gives us an error message as nothing as been selected
            //    lblError.Text = "Please Select an item to delete from the listbox";
            //}
        ///////////////



            //clsAppointmentCollection delete = new clsAppointmentCollection();
            //delete.Delete();
            //this.Hide();
            //frmListOfAppointments form = new frmListOfAppointments();
            //form.Show();
            //this.Close();

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
    //}


        void DeleteAppointment()
        {

            Int32 AppointmentID;
            if (txtAppointmentDate.Text != "")
            {
                AppointmentID = Convert.ToInt32(txtAppointmentDate.Text);
                //fiunction to cancel the required record
                //create instance of order
                clsAppointmentCollection appointment = new clsAppointmentCollection();
                //find record to cancel
                appointment.ThisAppointment.Find(AppointmentID);
                appointment.Delete();
                frmListOfAppointments Form = new frmListOfAppointments();
                Form.Refresh();
                lstAppointments.Refresh();
                lblError.Text = "The Order (Number: " + AppointmentID + " ) has been cancelled";
            }
            else
            {
                lblError.Text = "Please enter a valid Order Number";
            }
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

        private void lstAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
