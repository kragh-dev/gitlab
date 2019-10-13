<%@ Page Title="" Language="C#" MasterPageFile="~/movieCruiserCustomer.Master" AutoEventWireup="true" CodeBehind="ShowFavorites.aspx.cs" Inherits="movieCruiserOnline.ShowFavorites" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="menu">
        <div class="addItem">
            <h2>Movies</h2>
            <div class="favCountBox">
                <h4><asp:Label ID="lblCount" runat="server" Text="No of Favorites: " Visible="False"></asp:Label></h4><h2 id="favCount1" class="favCount"><asp:Label ID="favCount" CssClass="favCount" runat="server"></asp:Label></h2>
            </div>
        </div>
        <div class="favAddStatus">
            <p class="status" id="favStatus"></p>
        </div>
        <div class="menuList">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
            <asp:GridView ID="movieTable" CssClass="menuListTable" GridLines="None" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Name" />
                    <asp:TemplateField HeaderText="Has Teaser">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("HasTeaser") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("HasTeaser").ToString() == "True" ? "Yes" : "No" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Budget" DataFormatString="{0:c}" HeaderText="Budget" />
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "javascript:DeleteFromFavorites("+Eval("ID")+","+"1)" %>' Text="Delete"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="favEmptySection">
            <asp:Label ID="favEmpty" CssClass="favEmpty" runat="server"></asp:Label>
            <asp:HyperLink ID="favEmptyLink" runat="server" Visible="False" NavigateUrl="~/ShowMovieListCustomer.aspx">Movie List</asp:HyperLink>
        </div>
    </div>
    <script src="js/DeleteFromFavorites.js"></script>
</asp:Content>
