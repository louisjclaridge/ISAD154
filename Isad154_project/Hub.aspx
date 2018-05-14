<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hub.aspx.cs" Inherits="Isad154_project.Hub" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hub page</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous"/>
    <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    <link href="https://fonts.googleapis.com/css?family=Oswald" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container" class="mx-auto d-block">
        <div id="hub-container" class="mx-auto d-block" style="width:50%; text-align:center;">
        <div >
            <asp:Button ID="BtnCreateBooking" runat="server" Text="Create Booking" OnClick="Button1_Click" />
            <br />
        </div>
        <asp:Button ID="BtnViewBooking" runat="server" Text="View Booking" OnClick="BtnViewBooking_Click" />
        </div>
        </div>
    </form>
</body>
</html>
