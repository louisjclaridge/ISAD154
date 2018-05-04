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
            string email, accountType, firstName, lastName, address, phoneNumber, dateOfBirth;
            int id;


            id = rand.Next(1, 22000);
            email = txtEmail.Text;
            accountType = drpAccountType.SelectedItem.Text;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            dateOfBirth = txtDateOfBirth.Text;
            address = txtAddress.Text;
            phoneNumber = txtPhoneNumber.Text;


            if (accountType.Contains("Staff"))
            {
                Classes.Staff newStaff = new Classes.Staff(id, accountType, firstName, lastName, dateOfBirth, address, email, phoneNumber);
                lblTestOutput.Text = newStaff.getAllInfo();
            }
            if (accountType.Contains("Customer"))
            {
                Classes.Car newcar
                Classes.Customer newCustomer = new Classes.Customer(id, accountType, firstName, lastName, dateOfBirth, address, email, phoneNumber);
                lblTestOutput.Text = newCustomer.getAllInfo();
            }

            else if (accountType.Contains("Manager"))
            {
                Classes.User newUser = new Classes.User(id, accountType, firstName, lastName, dateOfBirth, address, email, phoneNumber);
                lblTestOutput.Text = newUser.getAllInfo();
            }
        }


        private void saveToJson()
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}