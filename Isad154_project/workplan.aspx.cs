using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Text;
using System.IO;


namespace Isad154_project
{
    public partial class workplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            createWorkplan();
        }
        private void createWorkplan()
        {
            string newWorkplanProblem = txtProblem.Text;
            string newWorkplanCheckInDate = txtCheckInDate.Text;
            string newWorkplanDueDate = txtDueDate.Text;

            //Workplan newWorkplan = new Workplan(newWorkplanProblem, newWorkplanCheckInDate, newWorkplanDueDate);
            

            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using(JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();
                writer.WritePropertyName("workplanProblem");
                writer.WriteValue(newWorkplanProblem);
                writer.WritePropertyName("workplanCheckInDate");
                writer.WriteValue(newWorkplanCheckInDate);
                writer.WritePropertyName("workplanDueDate");
                writer.WriteValue(newWorkplanDueDate);
            }
            lblWorkplanNumber.Text = sw.ToString(); 
        }
        
    }
}