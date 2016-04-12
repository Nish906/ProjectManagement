<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyPage.aspx.cs" Inherits="MyPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">

    <article>
        <h2> Welcome </h2>
Article text goes here!<br />
        <br />
        <br />
        <asp:Button ID="btnMyBookings" runat="server" Text="My Bookings" Height="67px" Width="200px" Font-Names="Century Gothic" OnClick="btnMyBookings_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnListOfAppointments" runat="server" Text="List Of Appointments" Height="67px" Width="200px" Font-Names="Century Gothic" OnClick="btnListOfAppointments_Click"  />
        <br />
        <br />
        <br />
        <asp:Button ID="btnMyDetails" runat="server" Text="My Details" Height="67px" Width="200px" Font-Names="Century Gothic"  />
        <br />
        <br />
        <br />
        <asp:Button ID="btnViewPayments" runat="server" Text="View Payments" Height="67px" Width="200px" Font-Names="Century Gothic"  />

        <br />

        <br />

    </article>
</asp:Content>

