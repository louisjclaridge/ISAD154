using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Isad154_project.Classes
{
    public class Car
    {
        public int id;
        public string registration;
        public Boolean personalReg;
        public DateTime yearOfManafacturer;
        public string model;
        public string notes;
        public DateTime lastMOT;

        public Car(int carID, string carRegistration, Boolean carPersonalReg, DateTime carYearOfManafacturer, string carModel, string carNotes, DateTime carLastMOT)
        {
            id = carID;
            registration = carRegistration;
            personalReg = carPersonalReg;
            yearOfManafacturer = carYearOfManafacturer;
            model = carModel;
            notes = carNotes;
            lastMOT = carLastMOT;
        }
    }
}