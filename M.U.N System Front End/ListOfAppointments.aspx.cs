using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListOfAppointments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        //if statement to test if user has selected a date from the list
        if (lstBoxAppointments.SelectedIndex == -1)
        {
            //error message shown to user
            lblError.Text = "Please select a booking date from the list above!";
        }
        else
        {
            //send user to booking appointment page
            Response.Redirect("Booking Appointment.aspx");

        }
    }
    protected void btnFilter_Click(object sender, EventArgs e)
    {
        //if statement to test if user has entered a end date
        if (txtEndDate.Text == "")
        {
            //error message shown to user
            lblError.Text = "Please fill in the end date to filter list!";
        }

        else
        {
            //,message showing user what has changed
            lblError.Text = "List has been updated";
        }
    }
    protected void btnButton1_Click(object sender, EventArgs e)
    {
        //redirects user to booking appointments page
        Response.Redirect("Book Appointment.aspx");
    }
}