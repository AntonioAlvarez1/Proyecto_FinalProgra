<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="Proyecto_FinalProgra.Historial" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Historial Pacientes</h1>
    <p>
        Id consulta&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
    </p>
    <p>
        Nit Paciente&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxNit" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha y Hora&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date" Width="202px"></asp:TextBox>
    </p>
    <p>
        Temperatura&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTemperatura" runat="server"></asp:TextBox>
    </p>
    <p>
        Presion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPresion" runat="server"></asp:TextBox>
    </p>
    <p>
        Sintoma&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropSint" runat="server" Height="17px" Width="117px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAgregarSintoma" runat="server" OnClick="ButtonAgregarSintoma_Click" Text="Agregar" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" Height="120px" Width="215px">
        </asp:GridView>
    </p>
    <p>
        Diagnostico&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxDiagnostico" runat="server"></asp:TextBox>
    </p>
    <p>
        Tratamiento&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTratamiento" runat="server"></asp:TextBox>
    </p>
    <p>
        Receta&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListReceta" runat="server">
        </asp:DropDownList>
        <asp:Button ID="ButtonAgregaReceta" runat="server" OnClick="ButtonAgregaReceta_Click" Text="Receta" />
    </p>
    <p>
        Prox Visita&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>
        Costo Consulta&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>Q100</asp:ListItem>
            <asp:ListItem>Q200</asp:ListItem>
            <asp:ListItem>Q300</asp:ListItem>
            <asp:ListItem>Q400</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:GridView ID="GridViewHistorial" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" Text="Agregar Historial Paciente" />
    </p>
</asp:Content>
