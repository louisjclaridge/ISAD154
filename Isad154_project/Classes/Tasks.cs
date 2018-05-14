using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;


namespace Isad154_project.Classes
{
    public class Tasks
    {
        public int taskID { get; set; }
        public string taskParts { get; set; }
        public string taskDate { get; set; }
        public string taskCompletion { get; set; }
        public Tasks(int theTaskID, string theTaskParts, string theTaskDate, string theTaskCompletion)
        {
            taskID = theTaskID;
            taskParts = theTaskParts;
            taskDate = theTaskDate;
            taskCompletion = theTaskCompletion;
        }
        public void writeToJson()
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"C:/Users/logan/Documents/GitHub/ISAD154/Isad154_project/App_Data/tasks.json"))
            {
                string json = r.ReadToEnd();
                List<Tasks> items = JsonConvert.DeserializeObject<List<Tasks>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"C:/Users/logan/Documents/GitHub/ISAD154/Isad154_project/App_Data/tasks.json", newJson);
        }
        public string allTaskInfo()
        {
            string output = taskID + ", " + taskParts + ", " + taskDate + ", " + taskCompletion;

            return output;
        }
    }
}