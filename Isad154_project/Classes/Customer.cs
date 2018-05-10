using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class Customer : User

    {
        public List<Car> myCars { get; set; }
        public Customer(int userAccountID, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber, List<Car> customerListOfCars) : base(userAccountID, userAccountType, userFirstName, userLastName, userDateOfBirth, userAddress, userEmail, userPhoneNumber)
        {
            myCars = customerListOfCars;

        }
        public string getAllInfo()
        {
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber + "This is a customer class";
            return output;
        }
    }
=======
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

>>>>>>> 1b8db6ff9c45d636c02bcdcdb5763c597b3f9cc4
}