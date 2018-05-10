﻿using Isad154_project.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace Isad154_project
{
    public partial class CreateCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(CarId.Text,carReg.Text,carPersonal.Text,carYear.Text,carManufacture.Text,carModel.Text,carNotes.Text,carLastMOT.Text);

            newCar.writeToJson();
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            readCar();
        }


        public void readCar()
        {
            using (StreamReader r = new StreamReader("F:/Webdev/ISAD154/Isad154_project/App_Data/Car.json"))
            {

                string json = r.ReadToEnd();


                List<Car> items = JsonConvert.DeserializeObject<List<Car>>(json);

                //MessageBox.Show(items[1].CarReg.ToString());


            }
            

        }

        public static List<Car> getAllCars()
        {
            using (StreamReader r = new StreamReader("F:/Webdev/ISAD154/Isad154_project/App_Data/Car.json"))
            {

                string json = r.ReadToEnd();


                List<Car> items = JsonConvert.DeserializeObject<List<Car>>(json);
                return items;


            }


        }
        //****************************************************
        //****************************************************
        //REFERENCE REAL GET ALL USERS
        //SHOULD BE IN LOUIS CREATE USER PAGE
        //********************************************
        //********************************************
        public static List<Customer> getAllUsers()
        {
            using (StreamReader r = new StreamReader("F:/Webdev/ISAD154/Isad154_project/App_Data/customers.json"))
            {

                string json = r.ReadToEnd();


                List<Customer> items = JsonConvert.DeserializeObject<List<Customer>>(json);
                return items;


            }


        }
    }
}