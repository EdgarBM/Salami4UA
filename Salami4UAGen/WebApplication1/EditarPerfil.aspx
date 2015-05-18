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

    <div style= 'height: 320px; width: 225px; border: 3px; float: left' >
    <asp:Label ID="Label11" runat="server" Text="Nationality" Width="100px"></asp:Label>
        <asp:DropDownList ID="Nacionalidad" runat="server" Width="100px"></asp:DropDownList>

        <br />

   

        <asp:Label ID="Label19" runat="server" Text="Height" Width="100px"></asp:Label>
        <asp:DropDownList ID="Altura" runat="server" Width="100px"></asp:DropDownList>

        <br />

        <asp:Label ID="Label20" runat="server" Text="Body Type" Width="100px"></asp:Label>
        <asp:DropDownList ID="TiposDeCuerpo" runat="server" Width="100px"></asp:DropDownList>

        <br />

        <asp:Label ID="Label22" runat="server" Text="Ethnicity" Width="100px"></asp:Label>
        <asp:DropDownList ID="Etnia" runat="server" Width="100px"></asp:DropDownList>


        <br />

        <asp:Label ID="Label23" runat="server" Text="Eye Color" Width="100px"></asp:Label>
        <asp:DropDownList ID="ColorOjos" runat="server" Width="100px"></asp:DropDownList>

        <br />

        <asp:Label ID="Label24" runat="server" Text="Hair Color" Width="100px"></asp:Label>
        <asp:DropDownList ID="ColorPelo" runat="server" Width="100px"></asp:DropDownList>

        <br />

        <asp:Label ID="Label25" runat="server" Text="Hair Length" Width="100px"></asp:Label>
        <asp:DropDownList ID="LongitudPelo" runat="server" Width="100px"></asp:DropDownList>


        <br />

        <asp:Label ID="Label26" runat="server" Text="Hair Style" Width="100px"></asp:Label>
        <asp:DropDownList ID="EstiloPelo" runat="server" Width="100px"></asp:DropDownList>


        <br />

        <asp:Label ID="Label27" runat="server" Text="Smoke" Width="100px"></asp:Label>
        <asp:DropDownList ID="Fumar" runat="server" Width="100px"></asp:DropDownList>

        <br />

        <asp:Label ID="Label28" runat="server" Text="Religion" Width="100px"></asp:Label>
        <asp:DropDownList ID="Religion" runat="server" Width="100px"></asp:DropDownList>

        <br />

        <asp:Label ID="Label5" runat="server" Text="Genre" Width="100px"></asp:Label>
        <asp:DropDownList ID="Genero" runat="server" Width="100px"></asp:DropDownList>

        <br />

        <asp:Label ID="Label6" runat="server" Text="Look for" Width="100px"></asp:Label>
        <asp:DropDownList ID="Orientacion" runat="server" Width="100px"></asp:DropDownList>

        <br />    
    </div>

    <div style= 'height: 320px; width: 225px; border: 3px; float: left' >   
        
        <asp:Label ID="Label7" runat="server" Text="Date of birth" Width="100px"></asp:Label>
        <asp:Label ID="ErrorFechaNacimiento" runat="server" Width="200px" ForeColor="Red"></asp:Label>
        <asp:Calendar ID="Birthday" runat="server"></asp:Calendar>
    
    </div>

    <div style= 'height: 900px; width: 900px; border: 3px; float: left' >    
        
        <asp:Label ID="LabelAnimales" runat="server" Text="Pets" BorderColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Names="Tahoma" Font-Size="Large" Font-Strikeout="False" ForeColor="Silver"></asp:Label>
        <asp:Label ID="ErrorAnimales" runat="server" Text="" ForeColor="Red" ></asp:Label>
        <asp:CheckBoxList id="Animales" runat="server" RepeatDirection="Horizontal"
                            CellPadding="5" CellSpacing="5" RepeatColumns="10"></asp:CheckBoxList>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Features" BorderColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Names="Tahoma" Font-Size="Large" Font-Strikeout="False" ForeColor="Silver"></asp:Label>
        <asp:Label ID="ErrorCaracteristicas" runat="server" Text="" ForeColor="Red" ></asp:Label>
        <asp:CheckBoxList id="Caracteristicas" runat="server" RepeatDirection="Horizontal"
                                CellPadding="5" CellSpacing="5" RepeatColumns="10"></asp:CheckBoxList>
        <br />
    
        <asp:Label ID="Label2" runat="server" Text="Film Tastes" BorderColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Names="Tahoma" Font-Size="Large" Font-Strikeout="False" ForeColor="Silver"></asp:Label>
        <asp:Label ID="ErrorCine" runat="server" Text="" ForeColor="Red" ></asp:Label>
        <asp:CheckBoxList id="Cine" runat="server" RepeatDirection="Horizontal" 
                            CellPadding="5" CellSpacing="5" RepeatColumns="10"></asp:CheckBoxList>
        <br />
    
        <asp:Label ID="Label3" runat="server" Text="Music Tastes" BorderColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Names="Tahoma" Font-Size="Large" Font-Strikeout="False" ForeColor="Silver"></asp:Label>
        <asp:Label ID="ErrorMusica" runat="server" Text="" ForeColor="Red" ></asp:Label>
        <asp:CheckBoxList id="Musica" runat="server" RepeatDirection="Horizontal"
                               CellPadding="5" CellSpacing="5" RepeatColumns="10"></asp:CheckBoxList>
        <br />
    
        <asp:Label ID="Label4" runat="server" Text="Sports" BorderColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Names="Tahoma" Font-Size="Large" Font-Strikeout="False" ForeColor="Silver"></asp:Label>
        <asp:Label ID="ErrorDeportes" runat="server" Text="" ForeColor="Red" ></asp:Label>
        <asp:CheckBoxList id="Deportes" runat="server" RepeatDirection="Horizontal"
                            CellPadding="5" CellSpacing="5" RepeatColumns="10"></asp:CheckBoxList>
        <br />
    
        <asp:Label ID="Label8" runat="server" Text="Hobbies" BorderColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Names="Tahoma" Font-Size="Large" Font-Strikeout="False" ForeColor="Silver"></asp:Label>
        <asp:Label ID="ErrorHobbies" runat="server" Text="" ForeColor="Red" ></asp:Label>
        <asp:CheckBoxList id="Hobbies" runat="server" RepeatDirection="Horizontal"
                            CellPadding="5" CellSpacing="5" RepeatColumns="10"></asp:CheckBoxList>
        <br />
        <br />
    

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonActualizar" runat="server" Text="Update Profile" OnClick="ButtonActualizar_Click" class="button" />

    </div>    

 </asp:Content>
