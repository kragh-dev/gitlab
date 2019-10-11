<%@ Page Title="" Language="C#" MasterPageFile="~/movieCruiserCustomer.Master" AutoEventWireup="true" CodeBehind="ShowFavorites.aspx.cs" Inherits="movieCruiserOnline.ShowFavorites" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="menu">
        <div class="addItem">
            <h2>Movies</h2>
            <div class="favCountBox">
                <h4>No of Favorites:</h4><h2 id="favCount" class="favCount">3</h2>
            </div>
        </div>
        <div class="favAddStatus">
            <p class="status" id="favStatus"></p>
        </div>
        <div class="menuList">

            <asp:GridView ID="movieTable" runat="server"></asp:GridView>
        </div>
        <div class="favEmptySection">
            <p class="favEmpty" id="favEmpty"></p>
        </div>
    </div>
</asp:Content>
