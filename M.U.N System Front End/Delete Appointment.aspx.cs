using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Delete_Appointment : System.Web.UI.Page
{
    Int32 AppointmentID;


    protected void Page_Load(object sender, EventArgs e)
    {
        AppointmentID = Convert.ToInt32(Session["AppointmentID"]);
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteAppointment();
        //send user back to MyBookings
        Response.Redirect("MyBookings.aspx");
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //send user back to MyBookings
        Response.Redirect("MyBookings.aspx");
    }

    void DeleteAppointment()
    {
        //function to delete selected record
        //create instance of appointment book
        clsAppointmentCollection appointmentBook = new clsAppointmentCollection();
        //fimd the record to delete
        appointmentBook.ThisAppointment.Find(AppointmentID);
        //delete the record
        appointmentBook.Delete();
    }
}