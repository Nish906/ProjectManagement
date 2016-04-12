<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListOfAppointments.aspx.cs" Inherits="ListOfAppointments" %>

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
        <asp:ListBox ID="lstBoxAppointments" runat="server" Height="396px" Width="615px" DataSourceID="SqlDataSource1" DataTextField="Appointment_Date" DataValueField="Appointment_Date"></asp:ListBox>
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Appointment DatabaseConnectionString %>" SelectCommand="SELECT [Appointment Date] AS Appointment_Date, [Appointment Time] AS Appointment_Time FROM [tblAppointments]"></asp:SqlDataSource>
        
        
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="btnBook" runat="server" Height="33px" Text="Book Appointment" Width="170px" OnClick="btnBook_Click" />
        





        <asp:Button ID="btnButton1" runat="server" Text="Button1" Width="170px" Height="33px" OnClick="btnButton1_Click"/>
        





    </article>
</asp:Content>

