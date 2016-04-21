using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class StaffAddAppointment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Add()
    {
        clsAppointmentCollection AppointmentBook = new clsAppointmentCollection();
        Boolean OK;

        OK = AppointmentBook.ThisAppointment.ValidAppointmentDateMin(txtAddAppointment.Text);

        if (OK == true)
        {
            AppointmentBook.ThisAppointment.AppointmentDate = Convert.ToDateTime(txtAddAppointment.Text);
            AppointmentBook.Add();

        }
        else
        {
            lblError.Text = "These is a problem with the date you have entered";
        }

        ////create an instance of the appointment
        //clsAppointmentCollection AppointmentBook = new clsAppointmentCollection();
        ////validate the data on the webform
        //Boolean OK = AppointmentBook.ThisAppointment.ValidAppointmentDate(txtAddAppointment.Text);
        ////if data is ok then add it to the object
        //if (OK == true)
        //{
        //    AppointmentBook.ThisAppointment.AppointmentDate = Convert.ToDateTime(txtAddAppointment.Text);
        //    //add the record
        //    AppointmentBook.Add();
        //}

        //else
        //{
        //    lblError.Text = "These is a problem with the date you have entered";
        //}
    
    }



    protected void btnClear_Click(object sender, EventArgs e)
    {
        //clears all text boxes when clear button is clicked
        txtAddAppointment.Text = "";
        //label showing what has been done
        lblError.Text = "Date/Time has been cleared";
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //add new record
        Add();
        //all done so redirect back to main page
        Response.Redirect("StaffAppointments.aspx");
    }
}