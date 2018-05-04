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
        public string dateOfBirth;
        public string address;
        public string email;
        public string phoneNumber;

        public User(int userAccountID, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber)
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

        public string getAllInfo()
        {
         string output =  Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber;

            return output;
        }
    }
}