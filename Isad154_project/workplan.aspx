<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="workplan.aspx.cs" Inherits="Isad154_project.workplan" %>

<!DOCTYPE html>


<head runat="server"><title>workplan</title></head>

<body>
    <img src="assets/images/rustyrepairs.png" style="padding-bottom: 2%" class="mx-auto d-block img-fluid">
<form method ="post" runat="server">




        <div><p>booking number:</p><asp:Label Text="booking number will display here" runat="server" ID="lblBookingNumber" /></div>
        <h1>Select Workplan</h1>

    <asp:ListBox runat="server" Width="1111px" ID="lstboxWorkplan">
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:ListBox>

     
          
       <div><p>problem</p><asp:TextBox runat="server" ID="txtProblem" /></div> 
       <div><p>check in date</p><asp:TextBox runat="server" ID="txtCheckInDate" /></div>
        <div><p>due date</p><asp:TextBox runat="server" ID="txtDueDate" /></div>

            <br />
        </div>

       
            <asp:Button ID="btnCreateWorkplan" runat="server" OnClick="Button1_Click" Text="create workplan" Width="139px" />
    
        
    

        <h1>Select Task</h1>
    <asp:ListBox runat="server" Width="1111px" ID="lstboxTask">
        <asp:ListItem Text="text1" />
        <asp:ListItem Text="text2" />
    </asp:ListBox>
        
       <button id="btnAddNewWorkplan">Add Task to selected workplan</button>
</form>

   

</body>
