using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnMyBookings_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyBookings.aspx");
    }
    protected void btnListOfAppointments_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListOfAppointments.aspx");
    }
}