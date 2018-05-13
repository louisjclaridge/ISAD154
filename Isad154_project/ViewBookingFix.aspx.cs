using Isad154_project.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Isad154_project
{
    public partial class ViewBookingFix : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            if (!IsPostBack)
            {
                List<Booking> bookings = CreateBooking.getAllBooking();


                foreach (Booking b in bookings)
                {
                    s.Add(b.myBookingID);


                }
                dropDownBooking.DataSource = s;
                dropDownBooking.DataBind();
            }
        }

        protected void dropDownBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                List<User> users = CreateCar.getAllUsers();
                List<Car> cars = CreateCar.getAllCars();
                List<Booking> bookings = CreateBooking.getAllBooking();
                Booking book = getCurrentBooking();

                foreach (User us in users)
                {
                    if (us.accountID.ToString() == book.myCustomerID)
                    {
                        lblUser.Text = us.getAllInfo();
                    }
                }
                foreach (Car c in cars)
                {
                    //add car stuff here
                }
                txtStatus.Text = book.myStatus;
            }
            }

        protected void btnHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hub.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            saveChanges();
        }
        private void saveChanges()
        {
            Booking book = getCurrentBooking();
            foreach (Booking  b in CreateBooking.getAllBooking())
            {
                if (b.myBookingID == book.myBookingID)
                {
                    b.myStatus = txtStatus.Text;
                    saveToJson(b);
                }
            }
        }
        private void saveToJson(Booking b)
        {
            string newJson;
            using (StreamReader r = new StreamReader(@"C:/Users/Jack Parsons/Documents/GitHub/ISAD154/Isad154_project/App_Data/Booking.Json"))
            {
                string json = r.ReadToEnd();
                List<Booking> items = JsonConvert.DeserializeObject<List<Booking>>(json);
                foreach (Booking book in items)
                {
                    if (book.myBookingID == b.myBookingID)
                    {
                        book.myStatus = b.myStatus;
                    }
                }

                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"C:/Users/Jack Parsons/Documents/GitHub/ISAD154/Isad154_project/App_Data/Booking.Json", newJson);
        }
        private Booking getCurrentBooking()
        {
            List<Booking> bookings = CreateBooking.getAllBooking();
            Booking book = new Booking("0", "0", "0", "0");
            foreach (Booking b in bookings)
            {
                if (b.myBookingID == dropDownBooking.SelectedItem.Text)
                {
                    book = b;
                    
                }
              
            }
            return book;
            
        }
    }
}