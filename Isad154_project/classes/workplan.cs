using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Isad154_project;


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


   

    public Workplan(int inWorkplanNumber, string inWorkplanNotes, 
        string inWorkplanProblem, string inCheckInDate, string inDueDate, string inWorkplanStatus )
    {
        workplanNumber = inWorkplanNumber;
        workplanNotes = inWorkplanNotes;
        workplanProblem = inWorkplanProblem;
        checkInDate = inCheckInDate;
        dueDate = inDueDate;
        workplanStatus = inWorkplanStatus;
        
    }
    //temp constructor
    public Workplan(string inWorkplanProblem, string inCheckInDate, string inDueDate)
    {
        workplanProblem = inWorkplanProblem;
        checkInDate = inCheckInDate;
        dueDate = inDueDate;
    }

    //properties 

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
            return workplanNotes ;
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
    //methods 
    // need to select the file we are reading/saving to 

    //create workplan
    private void createWorkplan()
    {
       
    }
    


}