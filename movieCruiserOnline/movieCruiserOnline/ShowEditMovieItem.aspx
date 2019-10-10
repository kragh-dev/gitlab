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
                    <asp:Label ID="lblItemPrice" runat="server" Text="Price"></asp:Label>
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="editGross"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
