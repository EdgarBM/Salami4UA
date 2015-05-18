<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Account.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
            Create a new account
        </h2>
        <p>
            Please answer the following questions in order to complete the register method
        </p>
       
        <span class="failureNotification">
            <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
        </span>
        <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
                ValidationGroup="RegisterUserValidationGroup"/>
        <div class="accountInfo">
            <fieldset class="register">
                <legend>Information</legend>
                <p>
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nickname</asp:Label>
                    <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                            CssClass="failureNotification" ErrorMessage="The nickname is mandatory." ToolTip="The nickname is mandatory." 
                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">Email:</asp:Label>
                    <asp:TextBox ID="Email" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" 
                            CssClass="failureNotification" ErrorMessage="The email is mandatory." ToolTip="The email is mandatory." 
                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>

                    <asp:RegularExpressionValidator ID="EmailCheck" runat="server"
                        ControlToValidate="Email" ForeColor=Red ValidationGroup="RegisterUserValidationGroup"
                        ErrorMessage="Incorrect email. It must be from UA (@alu.ua.es)"
                        ValidationExpression="^\S+@alu\.ua\.es$" ></asp:RegularExpressionValidator>
                </p>
                
                <p>
                    <asp:Label ID="NationalityLabel" runat="server">Nationality: </asp:Label>
                    <asp:DropDownList ID="NacionalidadList" runat="server"></asp:DropDownList>
                                    
                </p>

                 <p>
                    <asp:Label ID="BodyTypeLabel" runat="server">Body type: </asp:Label>
                    <asp:DropDownList ID="TiposDeCuerpo" runat="server"> </asp:DropDownList>

                </p>

                <p>
                    <asp:Label ID="AlturaLabel" runat="server">Height: </asp:Label>
                    <asp:DropDownList ID="Height" runat="server"></asp:DropDownList>
                                    
                </p>

                <p>
                    <asp:Label ID="EthnicityLabel" runat="server">Ethnicity: </asp:Label>
                    <asp:DropDownList ID="Etnia" runat="server" style="margin-left: 10px"></asp:DropDownList>

                </p>

                 <p>
                     <asp:Label ID="EyeColorLabel" runat="server">Eye Color: </asp:Label>
                     <asp:DropDownList ID="ColorOjos" runat="server" Height="16px" style="margin-left: 0px"> </asp:DropDownList>

                </p>

                <p>
                    <asp:Label ID="HairColorLabel" runat="server">Hair Color: </asp:Label>
                    <asp:DropDownList ID="ColorPelo" runat="server"> </asp:DropDownList>

                </p>

                <p>
                    <asp:Label ID="HairLength" runat="server">Hair length: </asp:Label>
                    <asp:DropDownList ID="LongitudPelo" runat="server"></asp:DropDownList></p>


                <p>
                    <asp:Label ID="HairStyleLabel" runat="server">Hair style: </asp:Label>;
                    <asp:DropDownList ID="EstiloPelo" runat="server"> </asp:DropDownList>

                </p>

                <p>
                    <asp:Label ID="ReligionLabel" runat="server">Religion: </asp:Label>
                    <asp:DropDownList ID="Religion" runat="server"> </asp:DropDownList>

                </p>

                <p>
                    <asp:Label ID="SmokeLabel" runat="server">Smoke: </asp:Label>
                    <asp:DropDownList ID="Fumador" runat="server"> </asp:DropDownList>

                </p>

                            
            </fieldset>

            <p class="submitButton">
                <asp:Button ID="Continuar" runat="server" CommandName="MoveNext" Text="Continue" OnClick="Continuar_Click"
                        ValidationGroup="RegisterUserValidationGroup"/>
            </p>
        </div>
    
        <asp:Label ID="Label" runat="server" AssociatedControlID="Label"></asp:Label>

        
</asp:Content>
