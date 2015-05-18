<%@ Page Title="DesbloquearUsuario" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" 
    CodeBehind="DesbloquearUsuario.aspx.cs" Inherits="WebApplication1.DesbloquearUsuario" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <style type="text/css">
    .modalBackground
    {
        background-color: Black;
        filter: alpha(opacity=90);
        opacity: 0.8;
    }
    .modalPopup
    {
        background-color: #FFFFFF;
        border-width: 3px;
        border-style: solid;
        border-color: black;
        padding-top: 10px;
        padding-left: 10px;
        width: 420px;
        height: 600px;
    }
    
</style>


<h2>Unblock user</h2>

<p>
    <asp:Label ID="LabelBloqueo" runat="server"></asp:Label>
</p>

<p>
<asp:Button ID="ButtonAceptar" runat="server" Text="Accept" OnClick="ButtonAceptar_Click" class="button" Width="200px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="ButtonCancelar" runat="server" Text="Cancel" OnClick="ButtonCancelar_Click" class="button" Width="200px"/>
</p>

</asp:Content>