﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="workplan.aspx.cs" Inherits="Isad154_project.workplan" %>

<!DOCTYPE html>


<head runat="server"><title>workplan</title></head>

<body>
    <img src="assets/images/rustyrepairs.png" style="padding-bottom: 2%" class="mx-auto d-block img-fluid">
<form method ="post" runat="server">




        <div><p>booking number:</p><asp:Label Text="booking number will display here" runat="server" ID="lblBookingNumber" /></div>
        <h1>Select Workplan</h1>

    <asp:ListBox runat="server" Width="1111px" ID="lstboxWorkplan" AutoPostBack="true" OnSelectedIndexChanged="lstboxWorkplan_SelectedIndexChanged">
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:ListBox>

     
          
        <br />
        <br />
        workplan number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblWorkplanNumber" runat="server" Text="0"></asp:Label>
        <br />
        <br />
        car details:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCarDetails" runat="server" Text="0"></asp:Label>
        <br />

     
          
       <div><p>problem</p><asp:TextBox runat="server" ID="txtProblem" /></div> 
       <div><p>check in date</p><asp:TextBox runat="server" ID="txtCheckInDate" />&nbsp; </div>
        <div><p>due date</p><asp:TextBox runat="server" ID="txtDueDate" />
            <div><p>Notes</p><asp:TextBox runat="server" ID="txtNotes" Height="33px" Width="907px" /></div>
            <br />
        </div>

            <br />
        <br />
        <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlistStatus" runat="server">
    <asp:ListItem Value="Active"> Active </asp:ListItem>
    <asp:ListItem Value="Completed"> Completed </asp:ListItem>
        </asp:DropDownList>
        <br />

            <br />
        

       
            <asp:Button ID="btnCreateWorkplan" runat="server" OnClick="Button1_Click" Text="create workplan" Width="139px" />
    
        
    

        
&nbsp;<asp:Button ID="btnUpdateWorkplan" runat="server" Text="update workplan" Width="113px" OnClick="btnUpdateWorkplan_Click" />
        <h1>Select Task</h1>
    <asp:ListBox runat="server" Width="1111px" ID="lstboxTask">
        <asp:ListItem Text="Active"/>
        <asp:ListItem Text="Completed"/>
    </asp:ListBox>
        
       <button id="btnAddNewWorkplan">Add Task to selected workplan</button>
</form>

   

</body>
