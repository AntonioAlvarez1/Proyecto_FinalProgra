<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_FinalProgra._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>PACIENTES</h1>
        <p>
            NIt del Paciente&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextboxNitPaciente" runat="server" OnTextChanged="TextboxNitPaciente_TextChanged"></asp:TextBox>
        </p>
        <p>
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextboxNombre" runat="server"></asp:TextBox>
        &nbsp;</p>
        <p>
            Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        </p>
        <p>
            Direccion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxDIrereccion" runat="server"></asp:TextBox>
        </p>
        <p>
            Telefono&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
        </p>
        <p>
            Fecha Nacimiento&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Height="36px" OnClick="Button2_Click" Text="Agregar Paciente" Width="222px" />
&nbsp;<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
&nbsp;<asp:Button ID="Button1" runat="server" BackColor="#3333FF" BorderColor="Blue" ForeColor="#CC0000" Height="66px" OnClick="Button1_Click" Text="Guarda Historial" Width="219px" />
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
