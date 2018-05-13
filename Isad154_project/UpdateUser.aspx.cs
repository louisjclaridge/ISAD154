using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace Isad154_project
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (Classes.User u in getAllUsers())
                {
                    lstUsers.Items.Add(u.accountID + " " + u.firstName + " " + u.lastName);
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

        protected void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
                    Classes.User staff = getAllUsers()[lstUsers.SelectedIndex];

                    txtEmail.Text = staff.email;
                    txtPassword.Text = staff.password;
                    txtFirstName.Text = staff.firstName;
                    txtLastName.Text = staff.lastName;
                    txtDateOfBirth.Text = staff.dateOfBirth;
                    txtAddress.Text = staff.address;
                    txtPhoneNumber.Text = staff.phoneNumber;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
                   Classes.User user = getAllUsers()[lstUsers.SelectedIndex];

                   user.email = txtEmail.Text;
                   user.password = txtPassword.Text;
                   user.firstName = txtFirstName.Text;
                   user.lastName = txtLastName.Text;
                   user.dateOfBirth = txtDateOfBirth.Text;
                   user.address = txtAddress.Text;
                   user.phoneNumber = txtPhoneNumber.Text;
                   List<Classes.User> users = getAllUsers();
                   users[lstUsers.SelectedIndex] = user;
                   writeUpdateToJson(users);
            
            }

        private void writeUpdateToJson(List<Classes.User> inputUser)
        {
            List<Classes.User> user = inputUser;
            string newJson;
            using (StreamReader r = new StreamReader(@"F:/ISAD154/Isad154_project/App_Data/users.Json"))
            {
                newJson = JsonConvert.SerializeObject(user);
            }
            File.WriteAllText(@"F:/ISAD154/Isad154_project/App_Data/users.Json", newJson);
        }
    }
}

