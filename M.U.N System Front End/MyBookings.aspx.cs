using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class MyBookings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayBookings();
        }
    }
    protected void btnBookAppointment_Click(object sender, EventArgs e)
    {
        
    }

    void DisplayBookings()
    {
        //create an instance of the appointment collection class
        MyClassLibrary.clsAppointmentCollection AppointmentBooking = new MyClassLibrary.clsAppointmentCollection();
        //set the data source to the list of appointment dtaes in the collection
        lstBoxBookings.DataSource = AppointmentBooking.AppointmentsList;
        //set the name of the primary key
        lstBoxBookings.DataValueField = "AppointmentID";
        //set the data field to display
        lstBoxBookings.DataTextField = "FirstName";
        //////set datafiedl
        //lstBoxBookings.DataTextField = "LasttName";
        //lstBoxBookings.DataTextField = "EmailAddress";
        //lstBoxBookings.DataTextField = "AppointmentDetails";
        //bind the data to the list
        lstBoxBookings.DataBind();
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
    protected void txtStartDate_TextChanged(object sender, EventArgs e)
    {

    }
}