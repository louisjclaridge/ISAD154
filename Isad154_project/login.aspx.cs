using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using Newtonsoft.Json;

namespace Isad154_project
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (drpSelectUserType.SelectedItem.Text.Contains("Customer"))
            {

                foreach (Classes.Customer a in getAllCustomers())
                {
                    if (a.password == txtPassword.Text && a.email == txtEmail.Text)
                    {
                        lblSuccess.Text = "Login Successful";
                    }
                    else
                    {
                        lblSuccess.Text = "Login Unsuccessful";
                    }
                }
            }
            else if (drpSelectUserType.SelectedItem.Text.Contains("Staff"))
            {
                foreach (Classes.Staff a in getAllStaff())
                {
                    if (a.password == txtPassword.Text && a.email == txtEmail.Text)
                    {
                        lblSuccess.Text = "Login Successful";
                    }
                    else
                    {
                        lblSuccess.Text = "Login Unsuccessful";
                    }
                }
            }
            else if (drpSelectUserType.SelectedItem.Text.Contains("Manager"))
            {
                foreach (Classes.Manager a in getAllManagers())
                {
                    if (a.password == txtPassword.Text && a.email == txtEmail.Text)
                    {
                        lblSuccess.Text = "Login Successful";
                    }
                    else
                    {
                        lblSuccess.Text = "Login Unsuccessful";
                    }
                }
            }

        }

        public static List<Classes.Customer> getAllCustomers()
        {
            using (StreamReader r = new StreamReader("/App_Data/customers.json"))
            {
                string json = r.ReadToEnd();

                List<Classes.Customer> items = JsonConvert.DeserializeObject<List<Classes.Customer>>(json);
                return items;


            }
        }

        public List<Classes.Staff> getAllStaff()
        {
            using (StreamReader r = new StreamReader("F:/ISAD154/Isad154_project/App_Data/staff.json"))
            {
                string json = r.ReadToEnd();

                List<Classes.Staff> items = JsonConvert.DeserializeObject<List<Classes.Staff>>(json);
                return items;


            }

        }

        public static List<Classes.Manager> getAllManagers()
        {
            using (StreamReader r = new StreamReader("F:/ISAD154/Isad154_project/App_Data/managers.json"))
            {
                string json = r.ReadToEnd();

                List<Classes.Manager> items = JsonConvert.DeserializeObject<List<Classes.Manager>>(json);
                return items;


            }
        }
    }
}