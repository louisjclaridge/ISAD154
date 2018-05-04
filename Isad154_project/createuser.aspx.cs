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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string email, accountType, firstName, lastName, address, phoneNumber;

            email = txtEmail.Text;
            accountType = drpAccountType.SelectedItem.Text;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            address = txtAddress.Text;
            phoneNumber = txtPhoneNumber.Text;

            lblTestOutput.Text = email + " " + accountType + " " + firstName + " " + lastName + " " + address + " " + phoneNumber;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}