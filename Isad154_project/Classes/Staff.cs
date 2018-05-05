using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class Staff : User
    {
        bool availability;
        public Staff(int userAccountID, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber, bool staffAvailability) : base(userAccountID, userAccountType, userFirstName, userLastName, userDateOfBirth, userAddress, userEmail, userPhoneNumber)
        {
            availability = staffAvailability;
        }
        public string getAllInfo()
        {
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber + "This is a staff class" + availability.ToString();
            return output;
        }
    }
}