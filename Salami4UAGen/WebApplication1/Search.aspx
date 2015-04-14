<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Search.aspx.cs" Inherits="WebApplication1.Search" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
            Search
        </h2>
    <p>
        Select your preferences to find your ideal salami.
    </p>
       
        <span class="failureNotification">
            <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
        </span>
        <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
                ValidationGroup="RegisterUserValidationGroup"/>
        <div class="accountInfo">
            <fieldset class="filter">
                <legend>Filter</legend>
                <br />
                <p>
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

                     <br /><br />

                    <asp:Label ID="EyeColorLabel" runat="server">Eye Color: </asp:Label>
                    <asp:DropDownList ID="ColorOjos" runat="server" Height="16px" style="margin-left: 0px"> </asp:DropDownList>
           
                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="HairColorLabel" runat="server">Hair Color: </asp:Label>
                    <asp:DropDownList ID="ColorPelo" runat="server"> </asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="HairLength" runat="server">Hair length: </asp:Label>
                    <asp:DropDownList ID="LongitudPelo" runat="server"></asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="HairStyleLabel" runat="server">Hair style: </asp:Label>
                    <asp:DropDownList ID="EstiloPelo" runat="server"> </asp:DropDownList>

                    <br /><br />

                    <asp:Label ID="ReligionLabel" runat="server">Religion: </asp:Label>
                    <asp:DropDownList ID="Religion" runat="server"> </asp:DropDownList>
                    
                    &nbsp;&nbsp;&nbsp;

                    <asp:Label ID="SmokeLabel" runat="server">Smoke: </asp:Label>
                    <asp:DropDownList ID="Fumador" runat="server"> </asp:DropDownList>

                </p>
                

                            
            </fieldset>

            <p class="submitButton">
                <asp:Button ID="Buscar" runat="server" CommandName="MoveNext" Text="Search" OnClick="Search_Click"/>
            </p>
        </div>
    
        <asp:Label ID="Label" runat="server" AssociatedControlID="Label"></asp:Label>

        
</asp:Content>
