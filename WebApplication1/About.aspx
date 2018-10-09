<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;<asp:Button ID="Button1" runat="server" Height="52px" OnClick="Button1_Click" Text="Generate" Width="117px" />
    <asp:TextBox ID="TextBox1" runat="server" Height="27px" OnTextChanged="TextBox1_TextChanged" Width="192px"></asp:TextBox>
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" Height="213px" Width="458px" />
    <br/>
    
</asp:Content>
