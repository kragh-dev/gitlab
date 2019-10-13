<%@ Page Title="" Language="C#" MasterPageFile="~/movieCruiserCustomer.Master" AutoEventWireup="true" CodeBehind="ShowMovieListCustomer.aspx.cs" Inherits="movieCruiserOnline.ShowMovieListCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="menu">
        <div class="addItem">
            <h2>Movies</h2>
            <input type="image" src="images/addItem.svg" alt="addItem" height="30px"/>
        </div>
        <div class="favAddStatus">
            <p class="status" id="favStatus"></p>
            <p class="status1" id="favStatus1"></p>
        </div>
        <div class="menuList">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
            <asp:GridView ID="movieTable" runat="server" CssClass="menuListTable" GridLines="None" AutoGenerateColumns="False">
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
                    <asp:BoundField DataField="Genre" HeaderText="Genre" />
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "javascript:AddToFavorites("+Eval("ID")+","+"1)" %>' Text="Add to Favorites"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <script src="js/AddToFavorites.js"></script>
        </div>
    </div>
</asp:Content>
