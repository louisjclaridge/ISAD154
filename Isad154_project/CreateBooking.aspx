<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateBooking.aspx.cs" Inherits="Isad154_project.CreateBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Bookings</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Booking ID"></asp:Label>
            <br />
            <asp:TextBox ID="txtBookingID" runat="server"></asp:TextBox>
            <br />
            Pick customer</div>
        <asp:DropDownList ID="DropDownCustomer" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Button ID="CreateCustomerBtn" runat="server" Text="Create Customer" />
        </p>
        Pick Car<br />
        <asp:DropDownList ID="DropDownCar" runat="server" OnSelectedIndexChanged="DropDownCar_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Button ID="CreateCarBtn" runat="server" OnClick="CreateCarBtn_Click" Text="Create car" />
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="CreateBookingBtn" runat="server" OnClick="CreateBookingBtn_Click" Text="Create Booking" UseSubmitBehavior="False" />
        </p>
        <asp:Button ID="BtnHub" runat="server" OnClick="BtnHub_Click" Text="&lt; Hub" />
    </form>
</body>
</html>
