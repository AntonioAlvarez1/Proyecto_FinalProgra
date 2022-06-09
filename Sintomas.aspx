<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sintomas.aspx.cs" Inherits="Proyecto_FinalProgra.Sintomas1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Nuevos Sintomas</h1>
    <br />
    Codigo De Sintoma&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextCodigoSintoma" runat="server"></asp:TextBox>
    <br />
    Descripcion del sintoma<asp:TextBox ID="TextBoxsDescrip" runat="server" Height="75px" TextMode="MultiLine" Width="203px"></asp:TextBox>
    <br />
    <br />
    <asp:GridView ID="GridViewSintomas" runat="server">
    </asp:GridView>
    <br />
    <br />
    <br />
    <asp:Button ID="ButtonAgrega" runat="server" Height="36px" OnClick="ButtonAgrega_Click" Text="Agrega Sintoma" Width="202px" />
</asp:Content>
