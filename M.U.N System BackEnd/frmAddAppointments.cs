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
    public partial class frmAddAppointments : Form
    {
        public frmAddAppointments()
        {
            InitializeComponent();
        }

        private void frmAddAppointments_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           // DateTime val = Convert.ToDateTime(txtAppointmentDate.Text);

           // string sqlFormat = val.ToString("yyyy-MM-dd HH:mm:ss");
            

            //DateTime dt = DateTime.ParseExact(val, "dd.M.yyyy hh:mm:ss", null);
           // System.Data.SqlTypes.SqlDateTime dtSql = System.Data.SqlTypes.SqlDateTime.Parse(dt.ToString("dd/MM/yyyy"));

            //if (txtAppointmentDate.Text == "")
            //{
            //    lblError.Text = "Please enter the date into text box above";
            //}

            //Field = DateTime.Parse(txtAppointmentDate.Text);

            //Field = Convert.ToDateTime(txtAppointmentDate);
             
            
            Convert.ToDateTime(txtAppointmentDate);
           
            clsAppointmentCollection addAppointment = new clsAppointmentCollection();
            addAppointment.Add();
            this.Hide();
            frmListOfAppointments form = new frmListOfAppointments();
            form.Show();
            form.ShowDialog();
            this.Close();



            //if (txtAppointmentDate.Text == "")
                //{
            //    lblError.Text = "Please fill in all fields to continue!";
            //}
            //else
            //{
            //    // Display a message box informing the user of there selection 
            //    MessageBox.Show("You are about to add an appointment?", "My Application",
            //        //Displays Ok or cancel as buttons 
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //    //create instance of form
            //    frmListOfAppointments MyList = new frmListOfAppointments();
            //    //refresh List
            //    MyList.Refresh();
            //    //close form
            //    Close();
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }

        void Add()
        {
            MyClassLibrary.clsAppointmentCollection AppointmentBook = new clsAppointmentCollection();
            Boolean OK = AppointmentBook.ThisAppointment.ValidAppointmentDate(txtAppointmentDate);
            if (OK == true)
            {
                AppointmentBook.ThisAppointment.AppointmentDate = Convert.ToDateTime(txtAppointmentDate);
                AppointmentBook.Add;

            }
            else
            {
                lblError.Text = "Error";
            }
        }
    }
}
