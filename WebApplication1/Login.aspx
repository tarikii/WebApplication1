<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Login</h1>
    </div>

    <br />

    <div>
        <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TBName" runat="server" OnTextChanged="TBName_TextChanged" AutoPostBack="False"></asp:TextBox>
    </div>

    <br />

    <div>
        <asp:Button Text="Entrar" runat="server" ID="ButEntrar" OnClick="ButEntrar_Click" />
    </div>

    <br />

</asp:Content>
