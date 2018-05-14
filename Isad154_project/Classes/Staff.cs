using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;

namespace Isad154_project.Classes
{
    public class Staff
    {
        public string staffID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateofbirth { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string availability { get; set; }
        public Staff(string staffaccountID, string staffFirstName, string staffLastName, string staffDOB, string staffPhoneNumber, string staffAddress, string staffAvailability)
        {
            staffID = staffaccountID;
            firstName = staffFirstName;
            lastName = staffLastName;
            dateofbirth = staffDOB;
            phoneNumber = staffPhoneNumber;
            address = staffAddress;
            availability = staffAvailability;
        }
        public string getStaffInfo()
        {
            string output = staffID + " " + firstName + " " + lastName + " " + dateofbirth + " " + phoneNumber + " " + address + " " + availability;

            return output;
        }
    }
}