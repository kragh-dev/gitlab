<%@ Page Title="" Language="C#" MasterPageFile="~/movieCruiserAdmin.Master" AutoEventWireup="true" CodeBehind="ShowMovieListAdmin.aspx.cs" Inherits="movieCruiserOnline.ShowMovieListAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="menu">
        <div class="addItem">
            <h2>Movies</h2>
            <input type="image" src="images/addItem.svg" alt="addItem" height="30px"/>
        </div>
        <div class="menuList">
            <asp:GridView ID="movieTable" CssClass="menuListTable" runat="server" AutoGenerateColumns="False" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Budget" DataFormatString="{0:c}" HeaderText="Budget" />
                    <asp:TemplateField HeaderText="Active">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Active") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Active").ToString() == "True" ? "Yes" : "No" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date Of Launch">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DateOfLaunch") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Convert.ToDateTime(Eval("DateOfLaunch")).ToString("dd/MM/yyyy") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Genre" HeaderText="Genre" />
                    <asp:TemplateField HeaderText="Has Teaser">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("HasTeaser") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("HasTeaser").ToString() == "True" ? "Yes" : "No" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/ShowEditMovieItem.aspx?movieId=" + Eval("ID") %>' Text="Edit"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
