<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StaffAppointments.aspx.cs" Inherits="StaffAppointments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">

    <article>
        <h2> List Of Appointments</h2>
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
        <asp:ListBox ID="lstBoxAppointmentDates" runat="server" Height="343px" Width="428px" OnSelectedIndexChanged="lstBoxAppointmentDates_SelectedIndexChanged"></asp:ListBox>
        
        
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="btnAdd" runat="server" Height="33px" Text="Add Appointment" Width="108px" OnClick="btnBook_Click" />
        





        &nbsp;<asp:Button ID="btnUpdate" runat="server" Height="33px" Text="Update Appointment" Width="126px" OnClick="btnBook_Click" />
        





        &nbsp;<asp:Button ID="btnDelete" runat="server" Height="33px" Text="Delete Appointment" Width="120px" OnClick="btnBook_Click" />
        





        &nbsp;<asp:Button ID="btnBook" runat="server" Height="33px" Text="Book Appointment" Width="124px" OnClick="btnBook_Click" />
        






        </article>
</asp:Content>