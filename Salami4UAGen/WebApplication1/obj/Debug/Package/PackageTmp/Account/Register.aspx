﻿<%@ Page Title="Sign in" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Account.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .textEntry
        {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
            Create a new account
        </h2>

        <br />
        <asp:Label ID="Label" runat="server" AssociatedControlID="Label"></asp:Label>
        <asp:Label ID="ErrorNickname" runat="server" ForeColor="Red"></asp:Label>

        <% if (Label.Text == "") { %>
        <p>
            Please answer the following questions in order to complete the register.
        </p>
       
        <span class="failureNotification">
            <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
        </span>
        <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
                ValidationGroup="RegisterUserValidationGroup"/>
        <div class="accountInfo" style="height: 100%;">
            <fieldset class="register" style="background-color: #FBFDFF">
                <legend>Sign in</legend>
                <br />
                <div style= 'border-style: none; border-color: inherit; border-width: 3px; height: 213px; width: 436px; float: left; margin-left: 10px;'>
        
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Text="Genre" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver" Width="125px">Nickname</asp:Label>
                    <br />
                    <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                            CssClass="failureNotification" ErrorMessage="The nickname is mandatory." ToolTip="The nickname is mandatory." 
                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>

                    <br />

                    <asp:RegularExpressionValidator ID="UserRequiredSize" runat="server" ControlToValidate="UserName" 
                        ForeColor=Red ErrorMessage="Incorrect username. It must have almost 6 alphanumeric characters."
                        ValidationExpression="^[a-zA-Z0-9]{6,}$" ValidationGroup="RegisterUserValidationGroup"></asp:RegularExpressionValidator>
                
                    <br />
                    <br />
                
                    <br />
                
                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email" 
                        Text="Email" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver" Width="125px"></asp:Label>
                    <br />
                    <asp:TextBox ID="Email" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" 
                            CssClass="failureNotification" ErrorMessage="The email is mandatory." ToolTip="The email is mandatory." 
                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>

                    <br />

                    <asp:RegularExpressionValidator ID="EmailCheck" runat="server"
                        ControlToValidate="Email" ForeColor=Red ValidationGroup="RegisterUserValidationGroup"
                        ErrorMessage="Incorrect email. It must be from UA (@alu.ua.es)"
                        ValidationExpression="^\S+@alu\.ua\.es$" ></asp:RegularExpressionValidator>
                </div>
                <br />
               
               <div style= 'border-style: none; border-color: inherit; border-width: 3px; height: 211px; width: 184px; float: left; line-height: 2em; margin-top: 0px;' >
     
                    <asp:Label ID="LabelGenre" runat="server" Text="Genre" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                    <br /><br />
                    <asp:DropDownList ID="Genero" runat="server"> </asp:DropDownList>

                    <br /><br /><br />
                
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver" Width="125px">Name</asp:Label>
                    <asp:TextBox ID="Name" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredName" runat="server" ControlToValidate="Name" 
                            CssClass="failureNotification" ErrorMessage="The name is mandatory." ToolTip="The name is mandatory." 
                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>

                
                </div>
                
                <div style= 'border-style: none; border-color: inherit; border-width: 3px; height: 211px; width: 208px; float: left; line-height: 2em; margin-top: 0px;' >
     
                    <asp:Label ID="LabelInterested" runat="server" Text="Interested in" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                    <br /><br />
                    <asp:DropDownList ID="Orientacion" runat="server"> </asp:DropDownList>

                    <br /><br /><br />

                    <asp:Label ID="SurnameLabel" runat="server" AssociatedControlID="Surname" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver" Width="125px">Surname</asp:Label>
                    <asp:TextBox ID="Surname" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredSurname" runat="server" ControlToValidate="Surname" 
                            CssClass="failureNotification" ErrorMessage="The surname is mandatory." ToolTip="The surname is mandatory." 
                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </div>

                <p>
                    <asp:Label ID="LabelInfo" runat="server" Text="Basic Information" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                    <br /><br />
                    <asp:Label ID="NationalityLabel" runat="server">Nationality: </asp:Label>
                    <asp:DropDownList ID="NacionalidadList" runat="server"></asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="BodyTypeLabel" runat="server">Body type: </asp:Label>
                    <asp:DropDownList ID="TiposDeCuerpo" runat="server"> </asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="AlturaLabel" runat="server">Height: </asp:Label>
                    <asp:DropDownList ID="Height" runat="server"></asp:DropDownList>
                    
                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="EthnicityLabel" runat="server">Ethnicity: </asp:Label>
                    <asp:DropDownList ID="Etnia" runat="server" style="margin-left: 10px"></asp:DropDownList>

                     &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="EyeColorLabel" runat="server">Eye Color: </asp:Label>
                    <asp:DropDownList ID="ColorOjos" runat="server" Height="16px" style="margin-left: 0px"> </asp:DropDownList>
           
                    <br /><br />

                    <asp:Label ID="HairColorLabel" runat="server">Hair Color: </asp:Label>
                    <asp:DropDownList ID="ColorPelo" runat="server"> </asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="HairLength" runat="server">Hair length: </asp:Label>
                    <asp:DropDownList ID="LongitudPelo" runat="server"></asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="HairStyleLabel" runat="server">Hair style: </asp:Label>
                    <asp:DropDownList ID="EstiloPelo" runat="server"> </asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="ReligionLabel" runat="server">Religion: </asp:Label>
                    <asp:DropDownList ID="Religion" runat="server"> </asp:DropDownList>
                    
                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="SmokeLabel" runat="server">Smoke: </asp:Label>
                    <asp:DropDownList ID="Fumador" runat="server"> </asp:DropDownList>


                </p>
                
                <br /><br />
                <p>
                    <asp:Label ID="BirthdayLabel" runat="server"  Width="100px">Birthdate: </asp:Label>
                    <asp:TextBox ID="FechaNacimiento" runat="server" CssClass="textEntry" ToolTip="Example: 02/09/1992" placeholder="Example: 02/09/1992" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFechaNacimiento" runat="server" ControlToValidate="FechaNacimiento" 
                        CssClass="failureNotification" ErrorMessage="The birthdate is mandatory." ToolTip="The birthdate is mandatory." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionFechaNacimiento" runat="server"
                        ControlToValidate="FechaNacimiento" ForeColor=Red ValidationGroup="RegisterUserValidationGroup"
                        ErrorMessage="Incorrect birthdate."
                        ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
                   
                    
                </p>
                
                <br /><br />
                <p>
                    <asp:Label ID="LabelAnimales" runat="server" Text="Animals" 
                        BorderColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Names="Tahoma" 
                        Font-Size="Large" Font-Strikeout="False" ForeColor="Silver"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="ErrorAnimales" runat="server" Text="" ForeColor="Red" ></asp:Label>
                    <asp:CheckBoxList ID="ListaAnimales" CellPadding="5" CellSpacing="5"
                                  RepeatColumns="10" RepeatDirection="Horizontal" runat="server" 
                        Width="100%"></asp:CheckBoxList>
               
               
                </p>
               <br /><br />
                <p>
                    <asp:Label ID="LabelCaracteristicas" runat="server" Text="Features" 
                        Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="ErrorCaracteristicas" runat="server" Text="" ForeColor="Red" ></asp:Label>
                    <asp:CheckBoxList ID="ListaCaracteristicas" CellPadding="5" CellSpacing="5"
                                  RepeatColumns="10" RepeatDirection="Horizontal" runat="server" Width="100%"
                        onselectedindexchanged="ListaCaracteristicas_SelectedIndexChanged"></asp:CheckBoxList>
               
                </p>
               <br /><br />
                <p>
                   <asp:Label ID="LabelCine" runat="server" Text="Film tastes" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                   &nbsp;&nbsp;&nbsp;
                   <asp:Label ID="ErrorCine" runat="server" Text="" ForeColor="Red"></asp:Label>
                   <asp:CheckBoxList ID="ListaCine" CellPadding="5" CellSpacing="5" Width="100%"
                                  RepeatColumns="10" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
               
                </p>
                <br /><br />
                <p>

                    <asp:Label ID="LabelMusica" runat="server" Text="Music" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="ErrorMusica" runat="server" Text="" ForeColor="Red"></asp:Label>
                    <asp:CheckBoxList ID="ListaMusica" CellPadding="5" CellSpacing="5" Width="100%"
                                  RepeatColumns="10" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
               
                </p>
                <br /><br />
                <p>

                   <asp:Label ID="LabelDeportes" runat="server" Text="Sports" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                   &nbsp;&nbsp;&nbsp;
                   <asp:Label ID="ErrorDeportes" runat="server" Text="" ForeColor="Red"></asp:Label>
                   <asp:CheckBoxList ID="ListaDeportes" CellPadding="5" CellSpacing="5" Width="100%"
                                  RepeatColumns="10" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
               
                </p>
               <br /><br />
                <p>
                   <asp:Label ID="LabelHobbies" runat="server" Text="Hobbies" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver" ></asp:Label>
                   &nbsp;&nbsp;&nbsp;
                   <asp:Label ID="ErrorHobbies" runat="server" Text="" ForeColor="Red"></asp:Label>
                   <asp:CheckBoxList ID="ListaHobbies" CellPadding="5" CellSpacing="5" Width="100%"
                                  RepeatColumns="10" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
                </p>

                <br /><br />

                <p>
                   <asp:Label ID="LabelComment" runat="server" Text="Something about you" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver" ></asp:Label>

                    <br /><br />

                   <asp:TextBox ID="Comment" runat="server" CssClass="textEntry" 
                       TextMode="MultiLine" Height="191px" Width="390px"  ></asp:TextBox>
                    
                    <br />
                </p>

                            
            </fieldset>

            <p class="submitButton" style="text-align: left; margin-left: 5%;">
                <asp:Button ID="Continuar" runat="server" CommandName="MoveNext" 
                    Text="Register" OnClick="Continuar_Click" class="button"
                    ValidationGroup="RegisterUserValidationGroup"/>
            </p>
        </div>
    
         <% }  %>

        
</asp:Content>
