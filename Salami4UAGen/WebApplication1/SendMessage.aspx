﻿<%@ Page Title="Send Message" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" 
    CodeBehind="SendMessage.aspx.cs" Inherits="WebApplication1.SendMessage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

        <h2>
            <asp:Label ID="SubtitleLabel" runat="server" Text="" />
        </h2>

        <br />
        <asp:Label ID="VerPerfilError" runat="server" Text=""></asp:Label>

        <% if (VerPerfilError.Text == "")
           { %>

        <br />
    <div style= 'border-style: none; border-color: inherit; border-width: 3px; height: 250px; width: 226px; float: left; margin-top: 3px; margin-bottom: 3px'>
        
        <asp:Image ID="ImagenPerfil" runat="server" Height="200px" Width="200px" />
        
    </div>

    <div id="divMessages" runat="server" style= 'border-style: none; border-color: inherit; border-width: 3px; min-height: 250px; width: 659px; float: left; line-height: 2em; margin: 3px 3px 3px 3px' >
       

    </div>

    <div style= 'height: 50px; width: 659px; border: 3px; float: Right' >
    
        <asp:Label ID="LabelReport" runat="server" ForeColor="Red" /><br />

        <asp:TextBox ID="textSend" runat="server" Width="500px" class="input"  />
        <asp:Button ID="buttonSend" runat="server" Text="Send" class="button" OnClick="sendMessage_Click"/>
        
    </div>

    <% } %>

</asp:Content>
