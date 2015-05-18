<%@ Page Title="Sign in" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Account.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
            Create a new account
        </h2>

        <br />
        <asp:Label ID="Label" runat="server" AssociatedControlID="Label"></asp:Label>

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
            <fieldset class="register">
                <legend>Sign in</legend>
                <p>
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nickname</asp:Label>
                    <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                            CssClass="failureNotification" ErrorMessage="The nickname is mandatory." ToolTip="The nickname is mandatory." 
                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>

                    <asp:RegularExpressionValidator ID="UserRequiredSize" runat="server" ControlToValidate="UserName" 
                    ForeColor=Red ErrorMessage="Incorrect username. It must have almost 6 alphanumeric characters."
                    ValidationExpression="^[a-zA-Z0-9]{6,}$" ValidationGroup="RegisterUserValidationGroup"></asp:RegularExpressionValidator>
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
                <br /><br />
                <p>
                    <asp:Label ID="LabelGenre" runat="server" Text="Genre" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                    <br /><br />
                    <asp:DropDownList ID="Genero" runat="server"> </asp:DropDownList>

                </p>
                <br /><br />
                <p>
                    <asp:Label ID="LabelInterested" runat="server" Text="Interested in" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium" ForeColor="Silver"></asp:Label>
                    <br /><br />
                    <asp:DropDownList ID="Orientacion" runat="server"> </asp:DropDownList>

                </p>
                <br /><br />
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
                    <asp:Label ID="BirthdayLabel" runat="server" Width="100px">Date of birth: </asp:Label>
                    <asp:Label ID="ErrorFechaNacimiento" runat="server" Width="300px" ForeColor="Red"></asp:Label>
                    <asp:Calendar ID="Birthday" runat="server"></asp:Calendar>
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
               

                            
            </fieldset>

            <p class="submitButton" style="text-align: left; margin-left: 5%;">
                <asp:Button ID="Continuar" runat="server" CommandName="MoveNext" 
                    Text="Register" OnClick="Continuar_Click"
                        ValidationGroup="RegisterUserValidationGroup" Height="26px" 
                    Width="77px"/>
            </p>
        </div>
    
         <% }  %>

        
</asp:Content>
