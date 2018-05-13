<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Isad154_project.UpdateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous"/>
    <link rel="stylesheet" type="text/css" href="stylesheet.css"/>
    <link href="https://fonts.googleapis.com/css?family=Oswald" rel="stylesheet"/>
    <title>Rusty Repairs | Create User</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <img src="rustyrepairs.png" class="mx-auto d-block img-fluid" style="padding-top:1%;">
        
<div id="container" class="mx-auto">
<div id="hub-container" class="mx-auto col-sm" style="text-align:center">
    <asp:Label ID="lblSelectUserType" runat="server" Text="SelectUserType"></asp:Label>
    <br />
    <asp:DropDownList ID="drpSelectUserType" runat="server" OnSelectedIndexChanged="drpSelectUserType_SelectedIndexChanged">
        <asp:ListItem>Staff</asp:ListItem>
        <asp:ListItem>Customer</asp:ListItem>
        <asp:ListItem>Manager</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblSelectUsers" runat="server" Text="Select A User"></asp:Label>
    <br />
    <asp:ListBox ID="lstUsers" runat="server" Width="310px" OnSelectedIndexChanged="lstUsers_SelectedIndexChanged"></asp:ListBox>
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
    <br>
    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <br>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <br>
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
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-dark" OnClick="btnSubmit_Click" />
        </div>
    </div>
        </div>
    </form>
</body>
</html>
