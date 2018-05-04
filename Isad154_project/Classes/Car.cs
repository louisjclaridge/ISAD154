﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class Car
    {

        public string CarReg { get; set; }
        public string CarPersonal { get; set; } // should be bool
        public string CarYear { get; set; }
        public string CarManufacture { get; set; }
        public string CarModel { get; set; }
        public string CarNotes { get; set; }
        public string CarLastMOT { get; set; } // should be datetime

        public Car(string theCarReg, String theCarPersonal, string theCarYear, string theCarManufacture, string theCarModel, string theCarNotes, string theCarLastMOT)
        {
            CarReg = theCarReg;
            CarPersonal = theCarPersonal;
            CarYear = theCarYear;
            CarManufacture = theCarManufacture;
            CarModel = theCarModel;
            CarNotes = theCarNotes;
            CarLastMOT = theCarLastMOT;
        }
        public void writeToJson()
        {


            string newJson;
            using (StreamReader r = new StreamReader(@"C:/Users/Jack Parsons/Documents/GitHub/ISAD154/Isad154_project/App_Data/car.Json"))
            {
                string json = r.ReadToEnd();
                List<Car> items = JsonConvert.DeserializeObject<List<Car>>(json);
                items.Add(this);
                newJson = JsonConvert.SerializeObject(items);
            }
            File.WriteAllText(@"C:/Users/Jack Parsons/Documents/GitHub/ISAD154/Isad154_project/App_Data/car.Json", newJson);



        }
    }
}

