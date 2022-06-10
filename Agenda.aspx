<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="Proyecto_FinalProgra.Agenda1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Agenda</h1>
    <p>
        NIt paciente
        <asp:TextBox ID="TextBoxNit" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
    </p>
    <p>
        Hora inicio&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxHI" runat="server" TextMode="Time"></asp:TextBox>
    </p>
    <p>
        Hora fin&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxHF" runat="server" TextMode="Time"></asp:TextBox>
    </p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="ButtonAgregacita" runat="server" OnClick="ButtonAgregacita_Click" Text="Agregar Cita" />
</asp:Content>
