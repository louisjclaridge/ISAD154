<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateTask.aspx.cs" Inherits="Isad154_project.CreateTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


p {
  margin: 0 0 10px;
}

  p {
    orphans: 3;
    widows: 3;
  }
  
* {
  -webkit-box-sizing: border-box;
     -moz-box-sizing: border-box;
          box-sizing: border-box;
}

  * {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    box-shadow: none !important;
  }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Task ID:
                <asp:TextBox ID="txtTaskID" runat="server"></asp:TextBox>
            </p>
            <p>
                Task Parts:
                <asp:DropDownList ID="drpdwnParts" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                Task Date:
                <asp:TextBox ID="txtTaskDate" runat="server"></asp:TextBox>
            </p>
            <p>
                Task Completion:
                <asp:TextBox ID="txtCompletion" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btn_submit" runat="server" OnClick="btn_submit_Click" Text="Submit" />
            </p>
            <p>
                Task History:</p>
            <p>
                <asp:ListBox ID="lstboxTasks" runat="server" Height="143px" Width="570px"></asp:ListBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
            <p>
            </p>
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
