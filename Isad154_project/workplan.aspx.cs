using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.IO;
using Isad154_project;
using System.Collections;




namespace Isad154_project
{
    public partial class workplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Workplan newWorkplan = new Workplan(txtProblem.Text, txtCheckInDate.Text, txtDueDate.Text);
            newWorkplan.CreateNewWorkplan();



        }
    }
}
        
        
            

            
