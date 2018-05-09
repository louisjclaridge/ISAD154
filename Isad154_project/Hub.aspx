<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hub.aspx.cs" Inherits="Isad154_project.Hub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hub page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnCreateBooking" runat="server" Text="Create Booking" OnClick="Button1_Click" />
            <br />
        </div>
        <asp:Button ID="BtnViewBooking" runat="server" Text="View Booking" OnClick="BtnViewBooking_Click" />
    </form>
</body>
</html>
