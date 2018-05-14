using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Isad154_project;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Collections;


/// <summary>
/// Summary description for workplan
/// </summary>
public class Workplan
{
    private int workplanNumber; 
    private string workplanNotes;
    private string workplanProblem;
    private string checkInDate; //maybe change to dates
    private string dueDate;  //maybe change to dates
    private string workplanStatus;
    //private ArrayList allWorkplans;




    public Workplan(int inWorkplanNumber, string inWorkplanNotes,
        string inWorkplanProblem, string inCheckInDate, string inDueDate, string inWorkplanStatus)
    {
        workplanNumber = inWorkplanNumber;
        workplanNotes = inWorkplanNotes;
        workplanProblem = inWorkplanProblem;
        checkInDate = inCheckInDate;
        dueDate = inDueDate;
        workplanStatus = inWorkplanStatus;


    }
   

    

    public int WorkplanNumber
    {
        get
        {
            return workplanNumber;
        }
        set
        {
            workplanNumber = value;
        }
    }
    public string WorkplanNotes
    {
        get
        {
            return workplanNotes;
        }
        set
        {
            workplanNotes = value;
        }
    }
    public string WorkplanProblem
    {
        get
        {
            return workplanProblem;
        }
        set
        {
            workplanProblem = value;
        }
    }
    public string CheckInDate
    {
        get
        {
            return checkInDate;
        }
        set
        {
            checkInDate = value;
        }
    }
    public string DueDate
    {
        get
        {
            return dueDate;
        }
        set
        {
            dueDate = value;
        }
    }
    public string WorkplanStatus
    {
        get
        {
            return workplanStatus;
        }
        set
        {
            workplanStatus = value;
        }
    }
  
   
    public void SaveWorkplan()
    {
        string newJson;
        using (StreamReader file = new StreamReader(@"C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/workplan.json"))
        {
            string json = file.ReadToEnd();
            List<Workplan> items = JsonConvert.DeserializeObject<List<Workplan>>(json);
            items.Add(this);
            newJson = JsonConvert.SerializeObject(items);
            
        }
        File.WriteAllText(@"C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/workplan.json", newJson);

    }
    public static List<Workplan> getWorkplans()
    {
        using (StreamReader file = new StreamReader("C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/workplan.json"))
        {
            string json = file.ReadToEnd();

            List<Workplan> items = JsonConvert.DeserializeObject<List<Workplan>>(json);

            return items;
        }
       

    }
    public static void UpdateWorkplan(List<Workplan> workplanInput)
    {
        List<Workplan> workplan = workplanInput;
        string newJson;

        using (StreamReader newStream = new StreamReader(@"C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/workplan.json"))
        {
            newJson = JsonConvert.SerializeObject(workplan);
        }
        File.WriteAllText(@"C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/workplan.json", newJson);
      
    }
    
  
}