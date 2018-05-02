<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCar.aspx.cs" Inherits="Isad154_project.CreateCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Car</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Car number (Not entered).<br />
            
            Enter Car Reg: <asp:TextBox runat="server" ID="car_Reg"/><br />
            Pesonal ? (Y/N): <asp:TextBox runat="server"/><br />
            Year: <asp:TextBox runat="server"/><br />
            Manufacture: <asp:TextBox runat="server"/><br />
            Model: <asp:TextBox runat="server"/><br />
            Notes: <asp:TextBox runat="server"/><br />
            Last MOT:<input type="datetime-local" class="form-control" id="inputDate" runat="server"/><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />
            <br/>


        </div>
    </form>
</body>
</html>
