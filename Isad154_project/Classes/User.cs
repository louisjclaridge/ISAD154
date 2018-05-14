using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace Isad154_project.Classes
{
    public class User
    {
        public string accountID { get; set; }
        public string password { get; set; }
        public string accountType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public List<Car> listOfCars { get; set; }
        public bool availability { get; set; }

        public User(string userAccountID, string userPassword, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber, List<Car> customerListOfCars, bool staffAvailability)
        {
            accountID = userAccountID;
            password = userPassword;
            accountType = userAccountType;
            firstName = userFirstName;
            lastName = userLastName;
            dateOfBirth = userDateOfBirth;
            address = userAddress;
            email = userEmail;
            phoneNumber = userPhoneNumber;
            listOfCars = customerListOfCars;
            availability = staffAvailability;
        }

        public string getAllInfo()
        {
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber + "This is a customer class";
            return output;
        }
        public void writeToJson()
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/users.json"))
            {
                string json = r.ReadToEnd();
                List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/users.Json", newJson);
        }
    }

}