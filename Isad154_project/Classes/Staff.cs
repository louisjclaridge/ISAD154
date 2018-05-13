using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.IO;

namespace Isad154_project.Classes
{
    public class Staff
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
        public bool availability { get; set; }
        public Staff(string staffAccountID, string staffPassword, string staffAccountType, string staffFirstName, string staffLastName, string staffDateOfBirth, string staffAddress, string staffEmail, string staffPhoneNumber, bool staffAvailability)
        {
            accountID = staffAccountID;
            password = staffPassword;
            accountType = staffAccountType;
            firstName = staffFirstName;
            lastName = staffLastName;
            dateOfBirth = staffDateOfBirth;
            address = staffAddress;
            email = staffEmail;
            phoneNumber = staffPhoneNumber;
            availability = staffAvailability;
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