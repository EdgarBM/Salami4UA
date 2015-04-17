<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Account.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Login
    </h2>
    <p>
        Please introduce your nickname and password. If you don't have an accout you can 
        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">register</asp:HyperLink> right now.
    </p>

    <asp:Label ID="ErrorValidacion" runat="server" CssClass="failureNotification"></asp:Label>

    <asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false">
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            
            
                
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Information Account</legend>
                    <p>

                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nickname</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" ErrorMessage="The nickname is mandatory." ToolTip="The nickname is mandatory." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" ErrorMessage="The password is mandatory." ToolTip="The password is mandatory." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Button ID="LoginButton" runat="server" Text="Login" ValidationGroup="LoginUserValidationGroup" onclick="LoginButton_Click" />
                        <asp:Button ID="ChangePasswordButton" runat="server" Text="ChangePassword" onclick="change_password" />
                    </p>
                </fieldset>
            </div>
        </LayoutTemplate>
    </asp:Login>
</asp:Content>
