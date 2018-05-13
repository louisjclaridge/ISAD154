<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBookingFix.aspx.cs" Inherits="Isad154_project.ViewBookingFix" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dropDownBooking" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropDownBooking_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblCar" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnHub" runat="server" OnClick="btnHub_Click" Text="&lt;Hub" />
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
    </form>
</body>
</html>
