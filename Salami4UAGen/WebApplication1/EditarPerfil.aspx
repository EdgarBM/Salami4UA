<%@ Page Title="EditarPerfil" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="EditarPerfil.aspx.cs" Inherits="WebApplication1.EditarPerfil" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Edit Profile
    </h2>

    <br />
    <asp:Label ID="ErrorInsertar" runat="server" Text="" ForeColor="Red"></asp:Label>
    
    <br />
    <br />
    <div style= 'border-style: none; border-color: inherit; border-width: 3px; height: 528px; width: 213px; float: left'>
        <img alt="" src="Imagenes/user.png" align="middle" height="200px" width:"200px" />
    </div>
    <div style= 'border-style: none; border-color: inherit; border-width: 3px; height: 277px; width: 289px; float: left' >
    
        <!--<asp:Label ID="Label2" runat="server" Text="Nationality" Width="100px"></asp:Label>
        <asp:DropDownList ID="Nationality" runat="server" Width="100px"></asp:DropDownList>

        <br /> -->

        <asp:Label ID="Label20" runat="server" Text="Body Type" Width="100px"></asp:Label>
        <asp:DropDownList ID="TiposDeCuerpo" runat="server" Width="100px"></asp:DropDownList>

        <br /><br />

        <asp:Label ID="Label22" runat="server" Text="Ethnicity" Width="100px"></asp:Label>
        <asp:DropDownList ID="Etnia" runat="server" Width="100px"></asp:DropDownList>


        <br /><br />

        <asp:Label ID="Label23" runat="server" Text="Eye Color" Width="100px"></asp:Label>
        <asp:DropDownList ID="ColorOjos" runat="server" Width="100px"></asp:DropDownList>

        <br /><br />

        <asp:Label ID="Label24" runat="server" Text="Hair Color" Width="100px"></asp:Label>
        <asp:DropDownList ID="ColorPelo" runat="server" Width="100px"></asp:DropDownList>

        <br /><br />

        <asp:Label ID="Label25" runat="server" Text="Hair Length" Width="100px"></asp:Label>
        <asp:DropDownList ID="LongitudPelo" runat="server" Width="100px"></asp:DropDownList>


        <br /><br />

        <asp:Label ID="Label26" runat="server" Text="Hair Style" Width="100px"></asp:Label>
        <asp:DropDownList ID="EstiloPelo" runat="server" Width="100px"></asp:DropDownList>


        <br /><br />

        <asp:Label ID="Label27" runat="server" Text="Smoke" Width="100px"></asp:Label>
        <asp:DropDownList ID="Fumar" runat="server" Width="100px"></asp:DropDownList>

        <br /><br />

        <asp:Label ID="Label28" runat="server" Text="Religion" Width="100px"></asp:Label>
        <asp:DropDownList ID="Religion" runat="server" Width="100px"></asp:DropDownList>

        <br /><br />

        <asp:Label ID="Label5" runat="server" Text="Genre" Width="100px"></asp:Label>
        <asp:DropDownList ID="Genero" runat="server" Width="100px"></asp:DropDownList>

        <br /><br />

        <asp:Label ID="Label6" runat="server" Text="Look for" Width="100px"></asp:Label>
        <asp:DropDownList ID="Orientacion" runat="server" Width="100px"></asp:DropDownList>

        <br /><br /><br />  
         
        <asp:Label ID="Label1" runat="server" Text="BirthDate" Width="100px"></asp:Label>
        <asp:TextBox ID="FechaNacimiento" runat="server" CssClass="textEntry" 
            ToolTip="Example: 02/09/1992" placeholder="Example: 02/09/1992" Width="176px" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFechaNacimiento" runat="server" ControlToValidate="FechaNacimiento" 
            CssClass="failureNotification" ErrorMessage="The birthdate is mandatory." ToolTip="The birthdate is mandatory." 
            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionFechaNacimiento" runat="server"
            ControlToValidate="FechaNacimiento" ForeColor=Red ValidationGroup="RegisterUserValidationGroup"
            ErrorMessage="Incorrect birthdate."
            ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
    
    </div>

    <div style= 'height: 50px; width: 800px; border: 3px; float: Right' >  
        
        <asp:Button ID="ButtonActualizar" runat="server" Text="Update Profile" OnClick="ButtonActualizar_Click" class="button" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="CancelPushButton" runat="server" class='button' CausesValidation="False" CommandName="Cancel" Text="Cancel"
                        OnClick="Cancel_Click"/>
    </div>    

 </asp:Content>
