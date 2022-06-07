<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePacientes.aspx.cs" Inherits="Proyecto_FinalProgra.UpdatePacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ACTUALIZAR PACIENTE</h1>
<h5>INGRESE ID PACIENTE PARA BUSCAR<asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
    <asp:Button ID="ButtonBuscar" runat="server" OnClick="Button1_Click" Text="BUSCAR" />
</h5>
<p>
    Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
</p>
<p>
    Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
</p>
<p>
    Direccion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
</p>
<p>
    Telefono&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" OnClick="ButtonModificar_Click" />
</p>
</asp:Content>
