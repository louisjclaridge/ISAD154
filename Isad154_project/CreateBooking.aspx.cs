using Isad154_project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Isad154_project
{
    public partial class CreateBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.Target = "_blank";

            List<Car> cars = CreateCar.getAllCars();
            List<string> s = new List<string>();
            foreach (Car c in cars)
            {
                s.Add(c.CarModel);

            }
            DropDownCar.DataSource = s;
            DropDownCar.DataBind();







            //var items = new List<string>
            //{
            //    "111",
            //    "222",
            //    "333"
            //};
            //items.Sort();
            //DropDownCar.DataSource = items;
            //DropDownCar.DataBind();
        }

        protected void CreateCarBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateCar.aspx");
        }
    }
}