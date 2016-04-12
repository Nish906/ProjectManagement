<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Book Appointment.aspx.cs" Inherits="Book_Appointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">
    <article>
        <h2> Book Appointment</h2>
        <p> 
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirstName" runat="server" Width="228px" BorderStyle="Solid"></asp:TextBox>
        </p>
        <p> 
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLastName" runat="server" Width="228px" BorderStyle="Solid"></asp:TextBox>
        </p>

                <p> 
            <asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" Width="228px" BorderStyle="Solid"></asp:TextBox>
        </p>
                        <p> 
            <asp:Label ID="lblAppoitmentDetails" runat="server" Text="Appointment Details"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAppointmentDetails" runat="server" Width="228px" BorderStyle="Solid"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <p> 
            <asp:Button ID="btnBook" runat="server" Height="57px" Text="Book Appointment" Width="133px" OnClick="btnBook_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" Height="57px" Text="Clear Appointment" Width="133px" OnClick="btnClear_Click" />
        </p>






    </article>
</asp:Content>

