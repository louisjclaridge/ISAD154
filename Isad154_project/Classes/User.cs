<<<<<<< HEAD
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
=======
﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.IO;
>>>>>>> 1b8db6ff9c45d636c02bcdcdb5763c597b3f9cc4

namespace Isad154_project.Classes
{
    public class User
    {
<<<<<<< HEAD
        public int accountID { get; set; }
=======
        public string accountID { get; set; }
        public string password { get; set; }
>>>>>>> 1b8db6ff9c45d636c02bcdcdb5763c597b3f9cc4
        public string accountType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

<<<<<<< HEAD
        public User(int userAccountID, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber)
        {
            accountID = userAccountID;
=======
        public User(string userAccountID, string userPassword, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber)
        {
            accountID = userAccountID;
            password = userPassword;
>>>>>>> 1b8db6ff9c45d636c02bcdcdb5763c597b3f9cc4
            accountType = userAccountType;
            firstName = userFirstName;
            lastName = userLastName;
            dateOfBirth = userDateOfBirth;
            address = userAddress;
            email = userEmail;
            phoneNumber = userPhoneNumber;
<<<<<<< HEAD
=======

>>>>>>> 1b8db6ff9c45d636c02bcdcdb5763c597b3f9cc4
        }

        public string getAllInfo()
        {
<<<<<<< HEAD
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber;

            return output;
        }
=======
         string output =  Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber;

            return output;
        }

        public void writeUserToJson()
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"F:/ISAD154/Isad154_project/App_Data/users.json"))
            {
                string json = r.ReadToEnd();
                List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"F:/ISAD154/Isad154_project/App_Data/users.Json", newJson);
        }
>>>>>>> 1b8db6ff9c45d636c02bcdcdb5763c597b3f9cc4
    }
}