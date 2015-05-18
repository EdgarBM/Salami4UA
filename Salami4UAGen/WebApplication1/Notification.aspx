<%@ Page Title="Notification" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Notification.aspx.cs" Inherits="WebApplication1.Notification" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
            Notifications
        </h2>
    
            <% if (Session["login"] != null){ %>

        <span class="failureNotification">
            <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
        </span>
        <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
                ValidationGroup="RegisterUserValidationGroup"/>

        
    
        <div class="resoultInfo" style="margin-left: 10px">
            <h3>
                <asp:Label ID="sin_mensajes" runat="server" Text="Pending messages from:"></asp:Label>
            </h3>
            <br />


            <asp:GridView ID="GridViewMensajes" runat="server"
                 AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                GridLines="None" >
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle HorizontalAlign="Center" BorderColor="White" BorderStyle="Solid" 
                    BorderWidth="2px" BackColor="#EFF3FB" />
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Picture">
                        <ItemTemplate>
                           <asp:ImageButton ID="ImagenPerfilBuscador" runat="server" Height="70px" Width="70px" 
                                    PostBackUrl='<%#"~/SendMessage.aspx?msgTo=" + Eval("Nickname") %>' ImageUrl='<%# Eval("UrlFoto") %>'/>
                         </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nickname">
                        <ItemTemplate>
                           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"~/SendMessage.aspx?msgTo=" + Eval("Nickname") %>' 
                                            Text='<%#Bind("Nickname") %>'></asp:HyperLink>
                         </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Surname" HeaderText="Surname" />
                    <asp:BoundField DataField="Gender" HeaderText="Genre" />
                    <asp:BoundField DataField="Likes" HeaderText="Interested in" />
                    <asp:TemplateField HeaderText="Birthday">
                        <ItemTemplate>
                            <asp:Label ID="BirthLabel" runat="server" Text='<%# ChopString(Eval("Birthday").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server">
            </asp:ObjectDataSource>
            <br /><br />

        </div>
        
        <div class="resoultInfo" style="margin-left: 10px">
            <h3>
                <asp:Label ID="sin_pinchitos" runat="server" Text="Pending pinchitos from:"></asp:Label>
            </h3>
            <br />


            <asp:GridView ID="GridViewPinchitos" runat="server"
                 AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                GridLines="None" >
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle HorizontalAlign="Center" BorderColor="White" BorderStyle="Solid" 
                    BorderWidth="2px" BackColor="#EFF3FB" />
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Picture">
                        <ItemTemplate>
                           <asp:ImageButton ID="ImagenPerfilBuscador" runat="server" Height="70px" Width="70px" 
                                    PostBackUrl='<%#"VerPerfil.aspx/" + Eval("Nickname") %>' ImageUrl='<%# Eval("UrlFoto") %>'/>
                         </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nickname">
                        <ItemTemplate>
                           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"VerPerfil.aspx/" + Eval("Nickname") %>' 
                                            Text='<%#Bind("Nickname") %>'></asp:HyperLink>
                         </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Surname" HeaderText="Surname" />
                    <asp:BoundField DataField="Gender" HeaderText="Genre" />
                    <asp:BoundField DataField="Likes" HeaderText="Interested in" />
                    <asp:TemplateField HeaderText="Birthday">
                        <ItemTemplate>
                            <asp:Label ID="BirthLabel" runat="server" Text='<%# ChopString(Eval("Birthday").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server">
            </asp:ObjectDataSource>
            <br /><br />

        </div>
      
                 <% }
                   else
                   { 
                 %>
    
    <p>
        Please <a href="/Account/Login.aspx">Log in</a> to use this function
    </p>

                  <% }   %>

</asp:Content>
