<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="workplan.aspx.cs" Inherits="Isad154_project.workplan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/2000/svg"></html>
<head runat="server"><title>workplan</title></head>

<body>
<form runat="server">

 <div id="hub-main-container" class="mx-auto">

   <img src="assets/images/rustyrepairs.png" style="padding-bottom: 2%" class="mx-auto d-block img-fluid">
<div id="hub-container" class="mx-auto col-sm">
    <div id="hub-container" class="mx-auto">
        <div><p>booking number:</p><asp:Label Text="booking number will display here" runat="server" ID="lblBookingNumber" /></div>
        <h1>Select Workplan</h1>
    <asp:ListBox runat="server" Width="1111px" ID="lstboxWorkplan">
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:ListBox>
        <div><p>workplan number:</p>
            <asp:Label Text="workplan number will display here" runat="server" ID="lblWorkplanNumber" /></div>
       <div><p>problem</p><asp:TextBox runat="server" ID="txtProblem" /></div> 
       <div><p>check in date</p><asp:TextBox runat="server" ID="txtCheckInDate" /></div>
        <div><p>due date</p><asp:TextBox runat="server" ID="txtDueDate" /></div>
        <div><p>status</p><asp:Label Text="status will display here" runat="server" /></div>
        <div><button id="btnCreateNewWorkplan">Create new workplan</button></div>
      
        </div>
    <div id="hub-container" class="mx-auto col-sm">
        <h1>Select Task</h1>
    <asp:ListBox runat="server" Width="1111px" ID="lstboxTask">
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:ListBox>
        </div>

<button id="btnAddNewWorkplan">Add Task to selected workplan</button>
</form>
</div>
</div>
</body>
