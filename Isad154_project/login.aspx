<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Isad154_project.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="drpUserType">
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
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <asp:Label ID="lblSuccess" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
