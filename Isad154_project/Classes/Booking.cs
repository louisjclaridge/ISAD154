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
        public string myCustomerID { get; set; }
        public string myCarID { get; set; }
        //public Booking(Customer customer, Car car)
        //{
        //    myCustomer = customer;
        //    myCar = car;
        //}
        public Booking(string customerID, string carId)
        {
            myCustomerID = customerID;
            myCarID = carId;
        }
        public void writeToJson()
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"F:/ISAD154/Isad154_project/App_Data/Booking.Json"))
            {
                string json = r.ReadToEnd();
                List<Booking> items = JsonConvert.DeserializeObject<List<Booking>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"F:/ISAD154/Isad154_project/App_Data//Booking.Json", newJson);

        }

    }
}