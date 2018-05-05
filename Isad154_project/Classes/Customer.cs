using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.IO;

namespace Isad154_project.Classes
{
    public class Customer : User
    {
        public Customer(string userAccountID, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber, List<Car> customerListOfCars) : base(userAccountID, userAccountType, userFirstName, userLastName, userDateOfBirth, userAddress, userEmail, userPhoneNumber)
        {

        }
        public string getAllInfo()
        {
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber + "This is a customer class";
            return output;
        }

        public void writeToJson()
        {


            string newJson;
            using (StreamReader r = new StreamReader(@"F:/ISAD154/Isad154_project/users.json"))
            {
                string json = r.ReadToEnd();
                List<Customer> items = JsonConvert.DeserializeObject<List<Customer>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"F:/ISAD154/Isad154_project/users.Json", newJson);



        }
    }
}