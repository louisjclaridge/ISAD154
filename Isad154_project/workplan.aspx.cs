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
            if (!IsPostBack)
            {
                OutputWorkplan();
                //showWorkplanSelected();
            }


        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            MakeWorkplanObject();
            OutputWorkplan();




        }
        


        private void OutputWorkplan()
        {
            
            lstboxWorkplan.Items.Clear();
        
            List<Workplan> newW = Workplan.getWorkplans();       

            foreach (Workplan a in Workplan.getWorkplans())
            {
                lstboxWorkplan.Items.Add(getWorkplanDisplayFormula(a));
            }
        }
        private void MakeWorkplanObject()
        {
            Random wpn = new Random();
            int workplanNumber = wpn.Next(1, 100000000);

          // add unique ID check
            string workplanStatus = "Active";


            Workplan newWorkplan = new Workplan(workplanNumber, txtNotes.Text, txtProblem.Text, txtCheckInDate.Text, txtDueDate.Text, workplanStatus);
            newWorkplan.SaveWorkplan();



        }

        
        protected void lstboxWorkplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedWorkplan;
            //string curWorkplan = lstboxWorkplan.SelectedItem.ToString();
            selectedWorkplan = 0;
            selectedWorkplan = lstboxWorkplan.SelectedIndex;

            List<Workplan> newW = Workplan.getWorkplans();

            Workplan currentCompany = newW[selectedWorkplan];
            lblWorkplanNumber.Text = currentCompany.WorkplanNumber.ToString();          
            txtProblem.Text = currentCompany.WorkplanProblem;
            txtCheckInDate.Text = currentCompany.CheckInDate;
            txtDueDate.Text = currentCompany.DueDate;
            txtNotes.Text = currentCompany.WorkplanNotes;
            string listItem = currentCompany.WorkplanStatus;

            ddlistStatus.ClearSelection();
                if (listItem == "Active")
                {
                    ddlistStatus.Items.FindByValue("Active").Selected = true;
                }
                else
                {
                    ddlistStatus.Items.FindByValue("Completed").Selected = true;
                }
            }
        private void UpdateFromInput()
        {
           
            Workplan currentWorkplan = Workplan.getWorkplans()[lstboxWorkplan.SelectedIndex];

            currentWorkplan.WorkplanNumber = Int32.Parse(lblWorkplanNumber.Text);
            currentWorkplan.WorkplanNotes = txtNotes.Text;
            currentWorkplan.WorkplanProblem = txtProblem.Text;
            currentWorkplan.CheckInDate = txtCheckInDate.Text;
            currentWorkplan.DueDate = txtDueDate.Text;
            currentWorkplan.WorkplanStatus = ddlistStatus.Text;

            List<Workplan> newW = Workplan.getWorkplans();
            newW[lstboxWorkplan.SelectedIndex] = currentWorkplan;
            Workplan.UpdateWorkplan(newW);
            
        }
        public string getWorkplanDisplayFormula(Workplan selected)
        {
            string output;
            output = "WorkplanNumber: " + "   " + selected.WorkplanNumber + "   " + "WorkplanProblem:" + selected.WorkplanProblem + "   " + "CheckInDate: " + "   " + selected.CheckInDate + "   " + "DueDate: " + "   " + selected.DueDate + "   " + "WorkplanNotes: " + "  " + selected.WorkplanNotes + "WorkplanStatus: " + "   " + selected.WorkplanStatus;  //change this to be all the same 
            return output;
        }

        protected void btnUpdateWorkplan_Click(object sender, EventArgs e)
        {
            UpdateFromInput();
            OutputWorkplan();
        }
    }
        
    

    }
    
   



//needs to add car with matching workplan number , based on workplan selected display car below 
        
        
            

            
