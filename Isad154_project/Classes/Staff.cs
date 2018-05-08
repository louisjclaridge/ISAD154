using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.IO;

namespace Isad154_project.Classes
{
    public class Staff : User
    {
        bool availability;
        public Staff(string userAccountID, string userPassword, string userAccountType, string userFirstName, string userLastName, string userDateOfBirth, string userAddress, string userEmail, string userPhoneNumber, bool staffAvailability) : base(userAccountID, userPassword, userAccountType, userFirstName, userLastName, userDateOfBirth, userAddress, userEmail, userPhoneNumber)
        {
            availability = staffAvailability;
        }
        public string getAllInfo()
        {
            string output = Convert.ToString(accountID) + " " + accountType + " " + firstName + " " + lastName + " " + dateOfBirth + " " + address + " " + email + " " + phoneNumber + "This is a staff class" + availability.ToString();
            return output;
        }

        public void writeStaffToJson()
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"F:/ISAD154/Isad154_project/App_Data/staff.json"))
            {
                string json = r.ReadToEnd();
                List<Staff> items = JsonConvert.DeserializeObject<List<Staff>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"F:/ISAD154/Isad154_project/App_Data/staff.Json", newJson);
        }
    }
}