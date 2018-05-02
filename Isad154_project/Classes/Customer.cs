using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class Customer : User
    {
        public Customer(int userAccountID, string userAccountType, string userFirstName, string userLastName, DateTime userDateOfBirth, string userAddress, string userEmail, int userPhoneNumber) : base(userAccountID, userAccountType, userFirstName, userLastName, userDateOfBirth, userAddress, userEmail, userPhoneNumber)
        {
        }
    }
}