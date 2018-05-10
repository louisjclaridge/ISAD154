<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createuser.aspx.cs" Inherits="Isad154_project.createuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    <link href="https://fonts.googleapis.com/css?family=Oswald" rel="stylesheet">
    <title>Rusty Repairs | Create User</title>
</head>
<body>
    <form id="form1" runat="server">
<img src="rustyrepairs.png" class="mx-auto d-block img-fluid" style="padding-top:1%;">
<div id="container" class="mx-auto">
<div id="hub-container" class="mx-auto col-sm" style="text-align:center">
    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
    <br>
    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <br>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <br>
            <asp:Button ID="btnGenerate" runat="server" OnClick="Button1_Click" Text="Generate Password" CssClass="btn btn-dark" />
    <br>
    <asp:Label ID="accountTypeLabel" runat="server" Text="Account Type"></asp:Label>
            <br />
    <asp:DropDownList ID="drpAccountType" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Manager</asp:ListItem>
        <asp:ListItem Selected="True">Staff</asp:ListItem>
        <asp:ListItem>Customer</asp:ListItem>
            </asp:DropDownList> <br>
    <asp:Label ID="firstNameLabel" runat="server" Text="First Name"></asp:Label>
    <br>
    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br>
    <asp:Label ID="lastNameLabel" runat="server" Text="Last Name"></asp:Label>
    <br>
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br>
    <asp:Label ID="dateOfBirthLabel" runat="server" Text="Date Of Birth"></asp:Label>
    <br>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
            <br>
    <asp:Label ID="addressLabel" runat="server" Text="Address"></asp:Label>
    <br>
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br>
    <asp:Label ID="phoneNumberLabel" runat="server" Text="Phone Number"></asp:Label>
    <br>
    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            <br>
     <asp:Button ID="Submit" runat="server" Text="Button" OnClick="Submit_Click" CssClass="btn btn-dark"/>
        </div>
    </div>
        </div>
    </form>
    </body>
</html>
