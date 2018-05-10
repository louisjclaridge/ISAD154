<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Isad154_project.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    <link href="https://fonts.googleapis.com/css?family=Oswald" rel="stylesheet">
    <title>Rusty Repairs | Login</title>
</head>
<body>
    <form id="form1" runat="server">
<img src="rustyrepairs.png" class="mx-auto d-block img-fluid" style="padding-top:1%;">
<div id="container" class="mx-auto">
<div id="login-container" class="mx-auto col-sm" style="text-align:center">
        <h1>Login</h1>
        <div id="drpUserType" style="">
            <asp:Label ID="lblUserType" runat="server" Text="Select User Type"></asp:Label>
            <br />
            <asp:DropDownList ID="drpSelectUserType" runat="server">
                <asp:ListItem>Staff</asp:ListItem>
                <asp:ListItem>Customer</asp:ListItem>
                <asp:ListItem>Manager</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        </div>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        </p>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <p>
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" CssClass="btn btn-dark"/>
        </p>
        <asp:Label ID="lblSuccess" runat="server" Text=""></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
