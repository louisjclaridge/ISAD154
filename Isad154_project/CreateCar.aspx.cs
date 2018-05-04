using Isad154_project.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace Isad154_project
{
    public partial class CreateCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(carReg.Text,carPersonal.Text,carYear.Text,carManufacture.Text,carModel.Text,carNotes.Text,carLastMOT.Text);

            newCar.writeToJson();
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            readCar();
        }


        private void readCar()
        {
            using (StreamReader r = new StreamReader("C:/Users/Jack Parsons/Documents/GitHub/ISAD154/Isad154_project/App_Data/Car.json"))
            {
                string json = r.ReadToEnd();
                List<Car> items = JsonConvert.DeserializeObject<List<Car>>(json);
                MessageBox.Show(items[1].CarReg.ToString());
            }

        }
    }
}