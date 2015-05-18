<%@ Page Title="Buscar" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Buscar.aspx.cs" Inherits="WebApplication1.Buscar" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
            Search
        </h2>
    
            <% if (Session["login"] != null)
                   {
                        %>
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
                <p>
                    <asp:RadioButton id="RadioWoman" Text="Woman" Checked="True" GroupName="RadioGroup1" runat="server" />
                    <asp:RadioButton id="RadioMan" Text="Man" GroupName="RadioGroup1" runat="server" />
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
                
                
                <p class="submitButton">
                    <asp:Button ID="BuscarButton" runat="server" CommandName="MoveNext" Text="Search" OnClick="Search_Click"/>
                </p>
                            
            </fieldset>

        </div>
    
    
        <div class="resoultInfo">
            <h3><asp:Label ID="LabelSalami" runat="server"></asp:Label></h3>
            <br />

            <!--
            <asp:Table ID="Tabla" runat="server" BorderWidth="1" >
            </asp:Table> 
            -->

            <asp:GridView ID="GridView1" runat="server"
                 AutoGenerateColumns="False" >
                <RowStyle HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="Nickname" HeaderText="Nickname" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>

        </div>
        
                 <% }
                   else
                   { 
                 %>
    
    <p>
        Please <a href="/Account/Login.aspx">log in</a> to use this function.
    </p>
    
                 <% }   %>
</asp:Content>
