using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class Booking
    {

        //public Customer myCustomer { get; set; }
        //public Car myCar { get; set; }
        public string myBookingID { get; set; }
        public string myCustomerID { get; set; }
        public string myCarID { get; set; }
        public string myStatus { get; set; }
        //public Booking(Customer customer, Car car)
        //{
        //    myCustomer = customer;
        //    myCar = car;
        //}
        public Booking(string bookingID,string customerID, string carId, string bookingStatus)
        {
            myBookingID = bookingID;
            myCustomerID = customerID;
            myCarID = carId;
            myStatus = bookingStatus;
        }
        public void writeToJson()
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"C:/Users/Jack Parsons/Documents/GitHub/ISAD154/Isad154_project/App_Data/Booking.Json"))
            {
                string json = r.ReadToEnd();
                List<Booking> items = JsonConvert.DeserializeObject<List<Booking>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"C:/Users/Jack Parsons/Documents/GitHub/ISAD154/Isad154_project/App_Data/Booking.Json", newJson);

        }

    }
}