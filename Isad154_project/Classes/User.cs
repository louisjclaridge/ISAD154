using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class User
    {
        public int accountID;
        public string accountType;
        public string firstName;
        public string lastName;
        public DateTime dateOfBirth;
        public string address;
        public string email;
        public int phoneNumber;

        public User(int userAccountID, string userAccountType, string userFirstName, string userLastName, DateTime userDateOfBirth, string userAddress, string userEmail, int userPhoneNumber)
        {
            accountID = userAccountID;
            accountType = userAccountType;
            firstName = userFirstName;
            lastName = userLastName;
            dateOfBirth = userDateOfBirth;
            address = userAddress;
            email = userEmail;
            phoneNumber = userPhoneNumber;
        }
    }
}