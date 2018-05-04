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
            
            Enter Car Reg: <asp:TextBox runat="server" ID="carReg"/><br />
            Pesonal ? (Y/N): <asp:TextBox runat="server" ID="carPersonal"/><br />
            Year: <asp:TextBox runat="server" ID="carYear"/><br />
            Manufacture: <asp:TextBox runat="server" ID="carManufacture"/><br />
            Model: <asp:TextBox runat="server" ID="carModel"/><br />
            Notes: <asp:TextBox runat="server" ID="carNotes"/><br />
            Notes: <asp:TextBox runat="server" ID="carLastMOT"/><br />

           <%-- Last MOT:<input type="datetime-local" class="form-control" id="inputDate" runat="server"/><br />--%>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />
            <br/>


        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </form>
</body>
</html>
