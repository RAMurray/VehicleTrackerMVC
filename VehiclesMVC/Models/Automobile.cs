using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehiclesMVC.Models
{
    public class Automobile
    {
        public int ID { get; set; }
        public string VinNumber { get; set; }
        public string ImageURL { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public float Mileage { get; set; }

        //Tires
        public string FrontLeftTire { get; set; }
        public string FrontRightTire { get; set; }
        public string BackLeftTire { get; set; }
        public string BackRightTire { get; set; }
    }
}