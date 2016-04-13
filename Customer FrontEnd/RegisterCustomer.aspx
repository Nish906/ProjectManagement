<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterCustomer.aspx.cs" Inherits="EditPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Payment</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Register Customer</h1>
        <p>CustomerID</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="200px" ReadOnly="True">Automatic</asp:TextBox>
        </p>
        <p>First Name</p>
        <p>
            <asp:TextBox ID="txtFirstName" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Last Name</p>
        <p>
            <asp:TextBox ID="txtLastName" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Address</p>
        <p>
            <asp:TextBox ID="txtAddress" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Post Code</p>
        <p>
            <asp:TextBox ID="txtPostCode" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>City</p>
        <p>
            <asp:TextBox ID="txtCity" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>D.O.B</p>
        <p>
            <asp:Calendar ID="Calen" runat="server"></asp:Calendar>
        </p>
        <p>Email Address</p>
        <p>

           <asp:TextBox ID="txtEmailAdd" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Phone Number</p>
        <p>
            <asp:TextBox ID="txtPhoneNo" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Register Customer Details" Width="200px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </div>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        </p>
    </form>
</body>
</html>
