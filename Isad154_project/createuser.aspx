<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createuser.aspx.cs" Inherits="Isad154_project.createuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

    <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="accountTypeLabel" runat="server" Text="Account Type"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList> <%--test stuff later--%>
    <br><br>
    <asp:Label ID="firstNameLabel" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="lastNameLabel" runat="server" Text="Last Name"></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="dateOfBirthLabel" runat="server" Text="Date Of Birth"></asp:Label>
    <asp:Calendar ID="cldDateOfBirth" runat="server"></asp:Calendar>
    <br><br>
    <asp:Label ID="addressLabel" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="phoneNumberLabel" runat="server" Text="Phone Number"></asp:Label>
    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
    <br><br>
     <asp:Button ID="Submit" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
