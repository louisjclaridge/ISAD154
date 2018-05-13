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
            foreach (Classes.User a in getAllUsers())
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

        public static List<Classes.User> getAllUsers()
        {
            using (StreamReader r = new StreamReader("F:/ISAD154/Isad154_project/App_Data/users.json"))
            {
                string json = r.ReadToEnd();

                List<Classes.User> items = JsonConvert.DeserializeObject<List<Classes.User>>(json);
                return items;


            }
        }
    }
}