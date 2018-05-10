using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.IO;

namespace Isad154_project.Classes
{
    public class Customer
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

        public Customer(string customerAccountID, string customerPassword, string customerAccountType, string customerFirstName, string customerLastName, string customerDateOfBirth, string customerAddress, string customerEmail, string customerPhoneNumber, List<Car> customerListOfCars)
        {
            accountID = customerAccountID;
            password = customerPassword;
            accountType = customerAccountType;
            firstName = customerFirstName;
            lastName = customerLastName;
            dateOfBirth = customerDateOfBirth;
            address = customerAddress;
            email = customerEmail;
            phoneNumber = customerPhoneNumber;
            listOfCars = customerListOfCars;
        }

        public string getAllInfo()
        {
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber + "This is a customer class";
            return output;
        }
        public void writeToJson()
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"F:/ISAD154/Isad154_project/App_Data/customers.json"))
            {
                string json = r.ReadToEnd();
                List<Customer> items = JsonConvert.DeserializeObject<List<Customer>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"F:/ISAD154/Isad154_project/App_Data/customers.Json", newJson);
        }
    }

}