<%@ Page Title="" Language="C#" MasterPageFile="~/movieCruiserAdmin.Master" AutoEventWireup="true" CodeBehind="ShowEditMovieItem.aspx.cs" Inherits="movieCruiserOnline.ShowEditMovieItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="edit">
        <div class="editMovieForm">
            <div class="editMovieName">
                <asp:Label ID="lblMovieName" runat="server" Text="Name" CssClass="lblMovieName"></asp:Label>
                <asp:TextBox ID="txtMovieName" runat="server" CssClass="editName"></asp:TextBox>
            </div>
            <div class="editMovieDetails">
                <div class="editGrossBox">
                    <asp:Label ID="lblItemPrice" runat="server" Text="Budget"></asp:Label>
                    <asp:TextBox ID="txtGross" runat="server" CssClass="editGross"></asp:TextBox>
                </div>
                <div class="editActiveBox">
                    <asp:Label ID="lblItemActive" runat="server" Text="Active"></asp:Label>
                    <asp:RadioButtonList ID="radioItemActive" runat="server" RepeatDirection="Horizontal" CssClass="editActiveStatus" CellPadding="50" Height="16px">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="editDolBox">
                    <asp:Label ID="lblDOL" runat="server" Text="Date Of Launch"></asp:Label>
                    <asp:TextBox ID="txtDOL" runat="server" CssClass="editDOLDate" TextMode="Date"></asp:TextBox>
                </div>
                <div class="editCategoryBox">
                    <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
                    <asp:DropDownList ID="dropDownItemCategory" runat="server" CssClass="editCategoryDropDown">
                        <asp:ListItem>Action Sci-Fi</asp:ListItem>
                        <asp:ListItem>Adventure</asp:ListItem>
                        <asp:ListItem>Comedy Drama</asp:ListItem>
                        <asp:ListItem>Action</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
             <div class="editHasTeaserBox">
                <asp:Label ID="lblHasTeaser" runat="server" Text="Has teaser"></asp:Label>
                <asp:CheckBox ID="checkBoxHasTeaser" runat="server" CssClass="editHasTeaser" />
            </div>
            <div class="editUpdateButtonBox">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="editUpdateButton" OnClick="btnSave_Click" OnClientClick="return validateMovieItemForm()" />
                <script src="../../js/ValidateUpdate.js"></script>
            </div>
        </div>
    </div>
</asp:Content>
