using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Book_Appointment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        //if statement to make sure that appointment details is not empty 
        if (txtAppointmentDetails.Text == "")
        {
            //display error if txtbox is empty
            lblError.Text = "Please fill in appointment details!";
        }
        else
        {

            //send user to confirmation page
            AddBooking();
            Response.Redirect("Book Appointment Confirmation.aspx"); 

        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        //clears all text boxes when clear button is clicked
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmail.Text = "";
        txtAppointmentDetails.Text = "";
        //label showing what has been done
        lblError.Text = "Booking details have been cleared";
    }

    void AddAppointmentBooking()
    {
        MyClassLibrary.clsAppointmentCollection AppointmentBook = new MyClassLibrary.clsAppointmentCollection();
        Boolean OK = AppointmentBook.ThisAppointment.ValidAppointmentDetailMin(txtAppointmentDetails.Text);
        if (OK == true)
        {
            AppointmentBook.ThisAppointment.FirstName = txtFirstName.Text;
            AppointmentBook.ThisAppointment.LastName = txtLastName.Text;
            AppointmentBook.ThisAppointment.EmailAddress = txtEmail.Text;
            AppointmentBook.ThisAppointment.AppointmentDetails = txtAppointmentDetails.Text;

            AppointmentBook.AddBooking();
        }

        else
        {
            lblError.Text = "These was a problem";
        }
    }
    protected void txtAppointmentDate_TextChanged(object sender, EventArgs e)
    {
        
    }

    void AddBooking()
    {
        clsAppointmentCollection Appointment = new clsAppointmentCollection();
        Boolean OK = Appointment.ThisAppointment.ValidAppointmentDetailMax(txtAppointmentDetails.Text);
        if (OK == true)
        {
            Appointment.ThisAppointment.FirstName = txtFirstName.Text;
            Appointment.ThisAppointment.LastName = txtLastName.Text;
            Appointment.ThisAppointment.EmailAddress = txtEmail.Text;
            Appointment.ThisAppointment.AppointmentDetails = txtAppointmentDetails.Text;
            Appointment.ThisAppointment.AppointmentDate = Convert.ToDateTime(txtAppointmentDate.Text);
            Appointment.AddBooking();
        }
        else
        {
            lblError.Text = "There was a problem";
        }
    }

}