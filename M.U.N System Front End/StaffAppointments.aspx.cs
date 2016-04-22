﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffAppointments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (IsPostBack == false)
        //{
        //    DispayAppointmentDates();
        //}
    }

    //void DispayAppointmentDates()
    //{
    //    //create an instance of the appointment collection class
    //    MyClassLibrary.clsAppointmentCollection AppointmentDates = new MyClassLibrary.clsAppointmentCollection();
    //    //set the data source to the list of appointment dtaes in the collection
    //    lstBoxAppointmentDates.DataSource = AppointmentDates.BookedAppointmentsList;
    //    //set the name of the primary key
    //    lstBoxAppointmentDates.DataValueField = "AppointmentID";
    //    //set the data field to display
    //    lstBoxAppointmentDates.DataTextField = "AppointmentDate";
    //    //bind the data to the list
    //    lstBoxAppointmentDates.DataBind();
    //}

    protected void lstBoxAppointmentDates_SelectedIndexChanged(object sender, EventArgs e)
    {

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
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store te primary key value of the record to be deleted
        Int32 AppointmentID;
        //if a record has beem selected from the list
        if (lstBoxAppointmentDates.SelectedIndex != 1)
        {
            //get the primary key value of the record to delete
            AppointmentID = Convert.ToInt32(lstBoxAppointmentDates.SelectedValue);
            //store the data in the session object
            Session["AppointmentID"] = AppointmentID;
            //redirects to the delete page
            Response.Redirect("Delete Appointment.aspx");
        }

        else
        {
            //dispay error
            lblError.Text = "please select a record from the list";
        }



        ////if statement to test if user has selected a date from the list
        //if (lstBoxAppointmentDates.SelectedIndex == -1)
        //{
        //    //error message shown to user
        //    lblError.Text = "Please select a booking date from the list above!";
        //}
        //else
        //{
        //    //send user to booking appointment page
        //    Response.Redirect("Booking Appointment.aspx");

        //} 
    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        //if statement to test if user has selected a date from the list
        if (lstBoxAppointmentDates.SelectedIndex == -1)
        {
            //error message shown to user
            lblError.Text = "Please select a booking date from the list above!";
        }
        else
        {
            //send user to booking appointment page
            Response.Redirect("Book Appointment.aspx");
        } 
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session objectto indicate this is a new record
        Session["AppointmentID"] = -1;
        //redirct to the data entry page
        Response.Redirect("StaffAddAppointment.aspx");
    }
}