using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Isad154_project
{
    public partial class createuser : System.Web.UI.Page
    {
        Random rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string id, email, password, accountType, firstName, lastName, address, phoneNumber, dateOfBirth;
            bool availability;


            id = rand.Next(1, 22000).ToString();
            email = txtEmail.Text;
            password = txtPassword.Text;
            accountType = drpAccountType.SelectedItem.Text;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            dateOfBirth = txtDateOfBirth.Text;
            address = txtAddress.Text;
            phoneNumber = txtPhoneNumber.Text;
            List<Classes.Car> carlist = new List<Classes.Car>();

            if (accountType.Contains("Staff"))
            {
                availability = true;
                Classes.Staff newStaff = new Classes.Staff(id, password, accountType, firstName, lastName, dateOfBirth, address, email, phoneNumber, availability);

                newStaff.writeStaffToJson();
            }
            if (accountType.Contains("Customer"))
            {
                Classes.Car newCar = new Classes.Car("", "", "", "", "", "", "","");
                carlist.Add(newCar);
                Classes.Customer newCustomer = new Classes.Customer(id, password, accountType, firstName, lastName, dateOfBirth, address, email, phoneNumber, carlist);

                newCustomer.writeToJson();
            }

            else if (accountType.Contains("Manager"))
            {
                Classes.Manager newUser = new Classes.Manager(id, password, accountType, firstName, lastName, dateOfBirth, address, email, phoneNumber);

                newUser.writeUserToJson();
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = System.Web.Security.Membership.GeneratePassword(12, 2);
        }
    }
}