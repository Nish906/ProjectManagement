using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete_Appointment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //send user back to MyBookings
        Response.Redirect("MyBookings.aspx");
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //send user back to MyBookings
        Response.Redirect("MyBookings.aspx");
    }
}