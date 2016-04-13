<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateCustomer.aspx.cs" Inherits="EditPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Payment</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Update Customer</h1>
        <p>CustomerID</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="200px" ReadOnly="True">Automatic</asp:TextBox>
        </p>
        <p>First Name</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Last Name</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Address</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Post Code</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>City</p>
        <p>
            <asp:TextBox ID="TextBox6" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>D.O.B</p>
        <p>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>Email Address</p>
        <p>

           <asp:TextBox ID="TextBox8" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>Phone Number</p>
        <p>
            <asp:TextBox ID="TextBox9" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Update Customer Details" Width="200px" />
        </p>
    </div>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" style="height: 26px" />
        </p>
    </form>
</body>
</html>
