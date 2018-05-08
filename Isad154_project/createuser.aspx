<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createuser.aspx.cs" Inherits="Isad154_project.createuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
    <br>
    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <br>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <%--test stuff later--%>
            <asp:Button ID="btnGenerate" runat="server" OnClick="Button1_Click" Text="Generate Password" />
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
     <asp:Button ID="Submit" runat="server" Text="Button" OnClick="Submit_Click" />
        </div>
    </form>
    </body>
</html>
