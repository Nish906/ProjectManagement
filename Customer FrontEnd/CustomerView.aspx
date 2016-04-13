<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerView.aspx.cs" Inherits="Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment System</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</head>
<body>
    
    <form id="form1" runat="server">
    <div id ="Payments">
    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customer</h1>
        <asp:Button ID="Button1" runat="server" Height="90px" Text="Register" Width="300px" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="90px" Text="Update your details" Width="300px" OnClick="Button2_Click" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
