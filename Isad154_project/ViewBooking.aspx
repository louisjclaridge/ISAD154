v<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBooking.aspx.cs" Inherits="Isad154_project.ViewBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownBookings" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownBookings_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="DropCars" runat="server" OnSelectedIndexChanged="DropCars_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <asp:Label ID="lblCustomer" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="lblCar" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="BtnHub" runat="server" OnClick="BtnHub_Click" Text="&lt;Hub" />
    </form>
</body>
</html>
