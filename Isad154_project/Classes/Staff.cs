using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class Staff : User
    {
        public Staff(int userAccountID, string userAccountType, string userFirstName, string userLastName, DateTime userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber) : base(userAccountID, userAccountType, userFirstName, userLastName, userDateOfBirth, userAddress, userEmail, userPhoneNumber)
        {
        }
    }
}