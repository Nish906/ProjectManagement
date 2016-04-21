<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StaffAddAppointment.aspx.cs" Inherits="StaffAddAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">
    <article>
       <h2> Add Appointment</h2>
        <p> 
            <asp:Label ID="lblAppointmentDate" runat="server" Text="Appointment Date/Time"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddAppointment" runat="server" Width="228px" BorderStyle="Solid"></asp:TextBox>
        </p>
        
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                <p> 
            <asp:Button ID="btnAdd" runat="server" Height="57px" Text="Add Appointment" Width="133px" OnClick="btnAdd_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" Height="57px" Text="Clear Appointment" Width="203px" OnClick="btnClear_Click"/>
        </p>

    </article>
</asp:Content>

