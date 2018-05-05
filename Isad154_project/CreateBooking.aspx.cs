using Isad154_project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Isad154_project
{
    public partial class CreateBooking : System.Web.UI.Page
    {
        List<Car> carss = new List<Car>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Loaded");
            this.Form.Target = "_blank";//Open new page

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
            Booking booking = new Booking(DropDownCustomer.SelectedItem.Text,DropDownCar.SelectedItem.Text);
            booking.writeToJson();
        }
    }
}