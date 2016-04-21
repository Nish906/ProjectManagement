using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffAppointments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DispayAppointmentDates();
        }
    }

    void DispayAppointmentDates()
    {
        //create an instance of the appointment collection class
        MyClassLibrary.clsAppointmentCollection AppointmentDates = new MyClassLibrary.clsAppointmentCollection();
        //set the data source to the list of appointment dtaes in the collection
        lstBoxAppointmentDates.DataSource = AppointmentDates.AppointmentsList;
        //set the name of the primary key
        lstBoxAppointmentDates.DataValueField = "AppointmentID";
        //set the data field to display
        lstBoxAppointmentDates.DataTextField = "AppointmentDate";
        //bind the data to the list
        lstBoxAppointmentDates.DataBind();
    }

    protected void lstBoxAppointmentDates_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}