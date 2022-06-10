<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recetas.aspx.cs" Inherits="Proyecto_FinalProgra.Recetas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>MEDICAMENTO</h1>
    <p>
        Codigo de Medicamento&nbsp;
        <asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
    </p>
    <p>
        Ingrediente Generico&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxIngrediente" runat="server"></asp:TextBox>
    </p>
    <p>
        Laboratorio&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxLaboratorio" runat="server"></asp:TextBox>
    </p>
    <p>
        Enfermedades&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="153px">
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agrega Enfermedades" Width="180px" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Guardar" />
    </p>
</asp:Content>
