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
            OutputWorkplan();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Workplan newWorkplan = new Workplan(txtProblem.Text, txtCheckInDate.Text, txtDueDate.Text);
            newWorkplan.CreateNewWorkplan();
            OutputWorkplan();




        }
        
        public void OutputWorkplan()
        {
            
            lstboxWorkplan.Items.Clear();
            Workplan.ReadWorkplan();
            List<Workplan> newW = Workplan.ReadWorkplan();

            ////lstboxWorkplan.DataSource = newW;
            //lstboxWorkplan.Items.Add(newW.id);

            foreach (Workplan a in Workplan.ReadWorkplan())
            {
                lstboxWorkplan.Items.Add(a.getWorkplanDisplayFormula());
            }
        }
    }
}

//needs to add car with matching workplan number , based on workplan selected display car below 
        
        
            

            
