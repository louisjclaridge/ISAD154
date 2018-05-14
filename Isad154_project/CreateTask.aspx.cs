using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;
using Isad154_project.Classes;

namespace Isad154_project
{
    public partial class CreateTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            outputTasks();
            outputParts();
        }
        public void readTasks()
        {
            using (StreamReader t = new StreamReader(@"C:/Users/logan/Documents/GitHub/ISAD154/Isad154_project/App_Data/tasks.json"))
            {
                string json = t.ReadToEnd();
                List<Tasks> items = JsonConvert.DeserializeObject<List<Tasks>>(json);
            }
        }
        public static List<Tasks> getallTasks()
        {
            using (StreamReader t = new StreamReader(@"C:/Users/logan/Documents/GitHub/ISAD154/Isad154_project/App_Data/tasks.json"))
            {
                string json = t.ReadToEnd();
                List<Tasks> items = JsonConvert.DeserializeObject<List<Tasks>>(json);
                return items;
            }
        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            Tasks newTask = new Tasks(Convert.ToInt32(txtTaskID.Text), drpdwnParts.Text, txtTaskDate.Text, txtCompletion.Text);
            newTask.writeToJson();
            outputTasks();
        }
        public void outputTasks()
        {
            lstboxTasks.Items.Clear();
            foreach (Tasks t in getallTasks())
            {
                lstboxTasks.Items.Add(t.allTaskInfo());
            }
        }
        public static List<Parts> getallParts()
        {
            using (StreamReader p = new StreamReader(@"C:/Users/logan/Documents/GitHub/ISAD154/Isad154_project/App_Data/parts.json"))
            {
                string json = p.ReadToEnd();
                List<Parts> items = JsonConvert.DeserializeObject<List<Parts>>(json);
                return items;
            }
        }
        public void outputParts()
        {
            foreach (Parts p in getallParts())
            {
                drpdwnParts.Items.Add(p.allParts());
            }
        }
    }
}