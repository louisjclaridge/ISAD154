using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class User
    {
        public int accountID { get; set; }
        public string accountType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

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
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber;

            return output;
        }
    }
}