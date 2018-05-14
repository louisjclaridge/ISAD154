<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="parts.aspx.cs" Inherits="Isad154_project.parts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            commodity parts
            <br />
            <br />
            <asp:ListBox ID="lstBoxCommodity" runat="server" Height="131px" Width="721px"></asp:ListBox>
            <br />
            <br />
            specialised parts<br />
            <asp:ListBox ID="lstBoxSpecialised" runat="server" Height="111px" Width="718px"></asp:ListBox>
            <br />
            <br />
            returned parts<br />
            <asp:ListBox ID="lstBoxReturns" runat="server" Height="131px" Width="714px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
