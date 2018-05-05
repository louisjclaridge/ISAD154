<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateBooking.aspx.cs" Inherits="Isad154_project.CreateBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Bookings</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Pick customer</div>
        <asp:DropDownList ID="DropDownCustomer" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Button ID="CreateCustomerBtn" runat="server" Text="Create Customer" />
        </p>
        Pick Car<br />
        <asp:DropDownList ID="DropDownCar" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Button ID="CreateCarBtn" runat="server" OnClick="CreateCarBtn_Click" Text="Create car" />
        </p>
        <asp:Button ID="CreateBookingBtn" runat="server" OnClick="CreateBookingBtn_Click" Text="Create Booking" />
    </form>
</body>
</html>
