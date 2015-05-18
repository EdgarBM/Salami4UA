<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Perfil.aspx.cs" Inherits="WebApplication1.Perfil" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Profile
    </h2>
    
    <img alt="" src= align="middle" height="200px" width:"200px" />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Cambiar_Password_Click" />


 </asp:Content>