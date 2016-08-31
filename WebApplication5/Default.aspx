<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication5._Default" %>

<asp:Content runat="server" ID="Content" ContentPlaceHolderID="MainContent">
    <h1>Consultar CEP</h1>
    <asp:TextBox ID="txtCEP" runat="server" MaxLength="8"/>
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btn_ConsultarClick"/>
    <hr/>
    <asp:Literal ID="litResultado" runat="server"/>
</asp:Content>