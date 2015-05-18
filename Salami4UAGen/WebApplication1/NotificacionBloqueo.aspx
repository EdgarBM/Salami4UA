<%@ Page Title="NotificacionBloqueo" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" 
    CodeBehind="NotificacionBloqueo.aspx.cs" Inherits="WebApplication1.NotificacionBloqueo" %>

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


<h2>Blocked</h2>

<p>

    <asp:Label ID="LabelBloqueo" runat="server"></asp:Label>
    </p>

</asp:Content>