using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateAppointments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        if (txtAppointmentDetails.Text == "")
            //if statement to make sure that appointment details is not empty 
            if (txtAppointmentDetails.Text == "")
            {
                //display error if txtbox is empty
                lblError.Text = "Please fill in appointment details!";
            }
            else
            {
                //send user to confirmation page
                Response.Redirect("Book Appointment Confirmation.aspx");

            }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        {
            //clears all text boxes when clear button is clicked
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAppointmentDetails.Text = "";
            //label showing what has been done
            lblError.Text = "Booking details have been cleared";
        }
    }
}