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
            //getWorkplanInputs();
            //Workplan.CreateWorkplan(tempWorkplan);



        }
        Workplan tempWorkplan = null;
        private void getWorkplanInputs()
        {

            

            
            string newWorkplanProblem = txtProblem.Text;
            string newWorkplanCheckInDate = txtCheckInDate.Text;
            string newWorkplanDueDate = txtDueDate.Text;
            //ArrayList tempWorkplans = new ArrayList();

            //var initialJson = File.ReadAllText("C:\\Users\\Work\\Documents\\GitHub\\ISAD154\\Isad154_project\\App_Data\\workplan.json");

            //var array = JArray.Parse(initialJson);

            //var itemToAdd = new JObject();
            //itemToAdd["problem"] = newWorkplanProblem;
            //itemToAdd["checkInDate"] = newWorkplanCheckInDate;
            //itemToAdd["dueDate"] = newWorkplanDueDate;

            //var jsonToOutput = JsonConvert.SerializeObject(array, Formatting.Indented);


           
            //Workplan newWorkplan = new Workplan(newWorkplanProblem, newWorkplanCheckInDate, newWorkplanDueDate);
            //tempWorkplans.Add(tempWorkplan);

            //MemoryStream stream1 = new MemoryStream();
            //DataContract


            //tempWorkplan = newWorkplan;

            //return tempWorkplans;

            //    StringBuilder sb = new StringBuilder();
            //    StringWriter sw = new StringWriter(sb);

            //    using (JsonWriter writer = new JsonTextWriter(sw))
            //    {
            //        writer.Formatting = Formatting.Indented;

            //        writer.WriteStartObject();
            //        writer.WritePropertyName("workplanProblem");
            //        writer.WriteValue(newWorkplanProblem);
            //        writer.WritePropertyName("workplanCheckInDate");
            //        writer.WriteValue(newWorkplanCheckInDate);
            //        writer.WritePropertyName("workplanDueDate");
            //        writer.WriteValue(newWorkplanDueDate);
            //    }
            //    lblWorkplanNumber.Text = sw.ToString();
            //}

    
        }
    }
}