using Isad154_project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Isad154_project
{
    public partial class ViewBooking : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
            List<string> s = new List<string>();
            if (!IsPostBack)
            {
                List<Booking> bookings = CreateBooking.getAllBooking();
                

                foreach (Booking b in bookings)
                {
                    s.Add(b.myCustomerID);

                }
                DropDownBookings.DataSource = s;
                DropDownBookings.DataBind();
            }
            

           
        }

        protected void DropDownBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                List<Customer> users = CreateCar.getAllUsers();
                List<Car> cars = CreateCar.getAllCars();
                String selectedBooking = DropDownBookings.SelectedItem.Value;


                foreach (Customer us in users)
                {
                    if (us.accountID.ToString() == selectedBooking)
                    {
                        lblCustomer.Text = us.getAllInfo();
                    }
                }
                foreach (Car c in cars)
                {

                }
            }
            
        }

        protected void DropCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hub.aspx");
        }
    }
}