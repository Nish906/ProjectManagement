using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //function for adding new records
    void Add()
    {
        //create an instance of the customer 
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the webform 
        Boolean OK;
        OK = CustomerBook.ThisCustomer.ValidAddress(txtAddress.Text);
        OK = CustomerBook.ThisCustomer.ValidLastName(txtLastName.Text);
        OK = CustomerBook.ThisCustomer.ValidFirstName(txtFirstName.Text);
        OK = CustomerBook.ThisCustomer.ValidEmail(txtEmailAddress.Text);
        OK = CustomerBook.ThisCustomer.ValidCustomerPhoneNumber(txtPhoneNumber.Text);
        OK = CustomerBook.ThisCustomer.ValidPostCode(txtPostcode.Text);
        OK = CustomerBook.ThisCustomer.ValidCity(txtCity.Text);
        OK = CustomerBook.ThisCustomer.ValidCustomerDOB(txtDateOfBirth.Text);
        OK = CustomerBook.ThisCustomer.ValidGender(ddlGender.Text);
        OK = CustomerBook.ThisCustomer.ValidPassword(txtPassword.Text);
        OK = CustomerBook.ThisCustomer.ValidAge(txtAge.Text);

        //if the data is OK then add it to the object 
        if (OK == true)
        {
            //get the data entered by the user 
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.LastName = txtLastName.Text;
            CustomerBook.ThisCustomer.EmailAddress = txtEmailAddress.Text;
            CustomerBook.ThisCustomer.Password = txtPassword.Text;
            CustomerBook.ThisCustomer.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
            CustomerBook.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            CustomerBook.ThisCustomer.Gender = ddlGender.Text;
            CustomerBook.ThisCustomer.Age = Convert.ToInt32(txtAge.Text);
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.City = txtCity.Text;
            CustomerBook.ThisCustomer.PostCode = txtPostcode.Text;
            //add the record
            CustomerBook.Add();
        }
        else
        {
            //report an error
            lblMessage.Text = "There was a Problem";
        }
    }



    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //Add the new record
        Add();
        //send to page confermation 
        Response.Redirect("RegisterConfirmation.aspx");

    }
    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }
}