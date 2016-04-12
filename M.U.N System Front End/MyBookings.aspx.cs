using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyBookings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnBookAppointment_Click(object sender, EventArgs e)
    {
        
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
            Response.Redirect("Delete Appointment.aspx");
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
}