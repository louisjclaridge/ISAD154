using Isad154_project.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Isad154_project
{
    public partial class CreateBooking : System.Web.UI.Page
    {
        List<Car> carss = new List<Car>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Loaded");
            //this.Form.Target = "_blank";//Open new page
            if (!IsPostBack)
            {
                List<Car> cars = CreateCar.getAllCars();//Change to only the customers car
                List<string> s = new List<string>();
                foreach (Car c in cars)
                {
                    s.Add(c.CarId);

                }
                DropDownCar.DataSource = s;
                DropDownCar.DataBind();
                //List<Customer> customers = Classes.User.getAllInfo();

                carss = cars;




                List<Customer> users = CreateCar.getAllUsers();
                List<string> st = new List<string>();
                foreach (Customer u in users)
                {
                    st.Add(u.accountID.ToString() + "" + u.firstName + "" + u.lastName);
                }
                DropDownCustomer.DataSource = st;
                DropDownCustomer.DataBind();
            }
            
        }

        protected void CreateCarBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateCar.aspx");//Open New page
        }

        protected void CreateBookingBtn_Click(object sender, EventArgs e)
        {
            //Get selcted customer
            //get selected car
            //add to booking
            Booking booking = new Booking(DropDownCustomer.SelectedItem.ToString(),DropDownCar.SelectedItem.ToString());
            //MessageBox.Show(DropDownCustomer.SelectedItem.ToString(), DropDownCar.SelectedItem.ToString());
            booking.writeToJson();
        }

        protected void DropDownCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static List<Booking> getAllBooking()
        {
            using (StreamReader r = new StreamReader("F:/Webdev/ISAD154/Isad154_project/App_Data/Booking.json"))
            {

                string json = r.ReadToEnd();


                List<Booking> items = JsonConvert.DeserializeObject<List<Booking>>(json);
                return items;


            }


        }

        protected void BtnHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hub.aspx");
        }
    }
}