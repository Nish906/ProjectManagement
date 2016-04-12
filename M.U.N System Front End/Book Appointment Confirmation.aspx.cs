using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Book_Appointment_Confirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //send user back to booking 
        Response.Redirect("Book Appointment.aspx");
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //send user back to booking 
        Response.Redirect("Book Appointment.aspx");
    }
}