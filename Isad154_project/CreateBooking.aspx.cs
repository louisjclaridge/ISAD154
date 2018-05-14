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
    public partial class CreateBooking : System.Web.UI.Page
    {
        List<Car> carss = new List<Car>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Loaded");
            //this.Form.Target = "_blank";//Open new page
            if (!IsPostBack)
            {
                




                List<Classes.User> customers = CreateCar.getAllUsers();
                List<string> st = new List<string>();
                foreach (Classes.User C in customers)
                {
                    st.Add(C.accountID.ToString());
                }
                DropDownCustomer.DataSource = st;
                DropDownCustomer.DataBind();

                //List<Customer> customers = Classes.User.getAllInfo();

             
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
            Booking booking = new Booking(txtBookingID.Text.ToString(), DropDownCustomer.SelectedItem.ToString(),DropDownCar.SelectedItem.ToString(), "Alive");
            //MessageBox.Show(DropDownCustomer.SelectedItem.ToString(), DropDownCar.SelectedItem.ToString());
            booking.writeToJson();
        }

        protected void DropDownCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static List<Booking> getAllBooking()
        {
            using (StreamReader r = new StreamReader("C:/Users/louis/Desktop/combined project/ISAD154/Isad154_project/App_Data/Booking.json"))
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

        protected void DropDownCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Car> cars = CreateCar.getAllCars();//Change to only the customers car
            List<Classes.User> customers = CreateCar.getAllUsers();
            Classes.User currentCustomer = customers[0];
            foreach (Classes.User c in customers)
            {
                if (c.accountID == DropDownCustomer.SelectedValue.ToString())
                {
                    currentCustomer = c;
                }
            }
            List<string> s = new List<string>();
            foreach (Car c in currentCustomer.listOfCars)
            {
                s.Add(c.CarId);

            }
            DropDownCar.DataSource = s;
            DropDownCar.DataBind();
            carss = cars;
        }
    }
}