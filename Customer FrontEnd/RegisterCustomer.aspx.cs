using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerView.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            if (txtFirstName.Text == "")
            {
                if (txtLastName.Text == "")
                {
                    if (txtCity.Text == "")
                    {
                        if (txtPostCode.Text == "")
                        {
                            if (txtPhoneNo.Text == "")
                            {
                                if (txtAddress.Text == "")
                                {
                                    if (txtEmailAdd.Text == "")
                                    {
                                        lblError.Text = "Please fill in missing details.";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                lblError.Text = "";
            }
    }
}