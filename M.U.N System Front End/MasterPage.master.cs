using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    //varible Username
    string Username;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Username = (string)Session["Username"];
        btnLogOut.Visible = false;
        btnUserPage.Visible = false;

        /*if (Username != "")
        {

            txtSignIn.Visible = true;
            txtPassword.Visible = true;
            lblPassword.Visible = true;
            btnLogIn.Visible = true;
            btnRegister.Visible = true;
            btnLogOut.Visible = false;
            btnUserPage.Visible = false; 
            lblSignIn.Text = "Welcome " + Username;
        }
        /*else
        {
            txtSignIn.Visible = true;
            txtPassword.Visible = true;
            lblPassword.Visible = true;
            btnLogIn.Visible = true;
            btnRegister.Visible = true;
            btnLogOut.Visible = false;
            btnUserPage.Visible = false;
        }*/
    }
    protected void btnLogIn_Click1(object sender, EventArgs e)
    {
        //
        if (txtSignIn.Text == "")
        {
            if (txtPassword.Text == "")
            {
                lblLoginError.Text = "Username or Password Invalid";
            }
        }
        else
        {
            //assign value to variable "Username
            Username = Convert.ToString(txtSignIn.Text);
            //hide
            txtSignIn.Visible = false;
            txtPassword.Visible = false;
            lblPassword.Visible = false;
            btnLogIn.Visible = false;
            btnRegister.Visible = false;
            //view these buttons
            btnLogOut.Visible = true;
            btnUserPage.Visible = true;
            //welcome message with username = lblsignin
            lblSignIn.Text = "Welcome " + Username;
            //Session["Username"] = Username;
            
        }
    }
    protected void btnLogOut_Click1(object sender, EventArgs e)
    {

    }
    protected void btnUserPage_Click1(object sender, EventArgs e)
    {
        Response.Redirect("MyPage.aspx");
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void btnAppointments_Click(object sender, EventArgs e)
    {
        Response.Redirect("Appointments.aspx");
    }
    protected void btnAboutUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("AboutUs.aspx");
    }
    protected void btnContactUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactUs.aspx");
    }
}
