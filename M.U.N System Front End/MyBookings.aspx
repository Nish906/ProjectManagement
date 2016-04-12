<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyBookings.aspx.cs" Inherits="MyBookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">
    <article>
        <h2> My Bookings</h2>
                <asp:Label ID="lblStartDate" runat="server" Text="Start Date"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>

        &nbsp;&nbsp;

        <asp:Label ID="lblEndDate" runat="server" Text="End Date"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>

        &nbsp;&nbsp;

        <asp:Button ID="btnFilter" runat="server" Text="Filter By Dates" OnClick="btnFilter_Click" Width="155px" />
        <br />
        <asp:Label ID="lblCurrentAppointment" runat="server"></asp:Label>
        <br />
        <asp:ListBox ID="lstBoxBookings" runat="server" Height="396px" Width="615px"></asp:ListBox>





        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>





        <br />
        <asp:Button ID="btnNext" runat="server" Height="33px" Text="Next" Width="170px" />
        <asp:Button ID="btnPrevious" runat="server" Text="Previous" Width="171px" Height="33px" />
        <asp:Button ID="btnUpdateAppointment" runat="server" Text="Update Appointment" Width="170px" Height="33px" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete Appointment" Width="170px" Height="33px" OnClick="btnDelete_Click" />





    </article>
</asp:Content>

