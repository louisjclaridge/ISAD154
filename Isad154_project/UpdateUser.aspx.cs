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

            checkUserType();
        }

        protected void drpSelectUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkUserType();
        }

        public void checkUserType()
        {
            if (drpSelectUserType.SelectedItem.Text.Contains("Staff"))
            {
                lstUsers.Items.Clear();
                foreach (Classes.Staff s in getAllStaff())
                {
                    lstUsers.Items.Add(s.accountID + " " + s.firstName + " " + s.lastName);
                }
            }

            else if (drpSelectUserType.SelectedItem.Text.Contains("Customer"))
            {
                lstUsers.Items.Clear();
                foreach (Classes.Customer c in getAllCustomers())
                {
                    lstUsers.Items.Add(c.accountID + " " + c.firstName + " " + c.lastName);
                }
            }

            else if (drpSelectUserType.SelectedItem.Text.Contains("Manager"))
            {
                lstUsers.Items.Clear();
                foreach (Classes.Manager m in getAllManagers())
                {
                    lstUsers.Items.Add(m.accountID + " " + m.firstName + " " + m.lastName);
                }
            }
        }

        public static List<Classes.Customer> getAllCustomers()
        {
            using (StreamReader r = new StreamReader("F:/ISAD154/Isad154_project/App_Data/customers.json"))
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

        protected void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (drpSelectUserType.SelectedItem.Value.Contains("Staff"))
                {
                    Classes.Staff staff = getAllStaff()[lstUsers.SelectedIndex];

                    txtEmail.Text = staff.email;
                    txtPassword.Text = staff.password;
                    txtFirstName.Text = staff.firstName;
                    txtLastName.Text = staff.lastName;
                    txtDateOfBirth.Text = staff.dateOfBirth;
                    txtAddress.Text = staff.address;
                    txtPhoneNumber.Text = staff.phoneNumber;
                }

                if (drpSelectUserType.SelectedItem.Value.Contains("Customer"))
                {
                    Classes.Customer customer = getAllCustomers()[lstUsers.SelectedIndex];

                    txtEmail.Text = customer.email;
                    txtPassword.Text = customer.password;
                    txtFirstName.Text = customer.firstName;
                    txtLastName.Text = customer.lastName;
                    txtDateOfBirth.Text = customer.dateOfBirth;
                    txtAddress.Text = customer.address;
                    txtPhoneNumber.Text = customer.phoneNumber;
                }

                if (drpSelectUserType.SelectedItem.Value.Contains("Manager"))
                {
                    Classes.Manager manager = getAllManagers()[lstUsers.SelectedIndex];

                    txtEmail.Text = manager.email;
                    txtPassword.Text = manager.password;
                    txtFirstName.Text = manager.firstName;
                    txtLastName.Text = manager.lastName;
                    txtDateOfBirth.Text = manager.dateOfBirth;
                    txtAddress.Text = manager.address;
                    txtPhoneNumber.Text = manager.phoneNumber;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (drpSelectUserType.SelectedItem.Value == "Staff")
            {
                Classes.Staff staff = getAllStaff()[lstUsers.SelectedIndex];

                staff.email = txtEmail.Text;
                staff.password = txtPassword.Text;
                staff.firstName = txtFirstName.Text;
                staff.lastName = txtLastName.Text;
                staff.dateOfBirth = txtDateOfBirth.Text;
                staff.address = txtAddress.Text;
                staff.phoneNumber = txtPhoneNumber.Text;

            }

            if (drpSelectUserType.SelectedItem.Value == "Customer")
            {
                Classes.Customer customer = getAllCustomers()[lstUsers.SelectedIndex];

                customer.email = txtEmail.Text;
                customer.password = txtPassword.Text;
                customer.firstName = txtFirstName.Text;
                customer.lastName = txtLastName.Text;
                customer.dateOfBirth = txtDateOfBirth.Text;
                customer.address = txtAddress.Text;
                customer.phoneNumber = txtPhoneNumber.Text;
            }

            if (drpSelectUserType.SelectedItem.Value == "Manager")
            {
                Classes.Manager manager = getAllManagers()[lstUsers.SelectedIndex];

                manager.email = txtEmail.Text;
                manager.password = txtPassword.Text;
                manager.firstName = txtFirstName.Text;
                manager.lastName = txtLastName.Text;
                manager.dateOfBirth = txtDateOfBirth.Text;
                manager.address = txtAddress.Text;
                manager.phoneNumber = txtPhoneNumber.Text;
            }
        }
    }
    }
