<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="Proyecto_FinalProgra.Agenda1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Agenda</h1>
    <p>
        NIt paciente
        <asp:TextBox ID="TextBoxNit" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        Hora inicio&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxHI" runat="server" TextMode="DateTime"></asp:TextBox>
    </p>
    <p>
        Hora fin&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxHF" runat="server" TextMode="DateTime"></asp:TextBox>
    </p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="ButtonAgregacita" runat="server" OnClick="ButtonAgregacita_Click" Text="Agregar Cita" />
</asp:Content>
