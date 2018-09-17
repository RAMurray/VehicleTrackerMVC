using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehiclesMVC.Models;

namespace VehiclesMVC.DAL
{
    public class VehiclesInitializer : System.Data.Entity.DropCreateDatabaseAlways<VehiclesContext>
    {
        protected override void Seed(VehiclesContext oContext) 
        {
            var oAutomobiles = new List<Automobile>
            {
                new Automobile{VinNumber="55512TC", ImageURL="https://i.imgur.com/aDVvOp3.png", Year = 2018, Make="Toyota", Model="Camry", Mileage=3120,
                    FrontLeftTire="Good", FrontRightTire="Good", BackLeftTire="Good", BackRightTire="Good"},
                new Automobile{VinNumber="22518P1", ImageURL="https://i.imgur.com/oYDaOlC.png", Year = 2017, Make="Nissan", Model="Frontier", Mileage=5665,
                    FrontLeftTire="Good", FrontRightTire="Fair", BackLeftTire="Good", BackRightTire="Fair"},
                new Automobile{VinNumber="12RN85C", ImageURL="https://i.imgur.com/KKcZhU5.png", Year = 2016, Make="Ford", Model="Transit Wagon", Mileage=12455,
                    FrontLeftTire="Fair", FrontRightTire="Fair", BackLeftTire="Bad", BackRightTire="Bad"},
                new Automobile{ VinNumber="M3423C2", ImageURL="https://i.imgur.com/cwDTE2C.png", Year = 2018, Make="Zero", Model="FX ZF3.6", Mileage=210,
                    FrontLeftTire="Good", FrontRightTire="None", BackLeftTire="Good", BackRightTire="None"},
                new Automobile{VinNumber="2LOUD43", ImageURL="https://i.imgur.com/rTOp1fE.jpg", Year = 2012, Make="Harley-Davidson", Model="Softail Low Rider",
                    Mileage =21547, FrontLeftTire="Fair", FrontRightTire="None", BackLeftTire="Bad", BackRightTire="None"},
                new Automobile{VinNumber="5THANOS", ImageURL="https://i.imgur.com/vuWhKZo.jpg", Year = 2003, Make="Ford", Model="Ranger", Mileage=100000,
                    FrontLeftTire="Fair", FrontRightTire="Fair", BackLeftTire="Bad", BackRightTire="Bad"}
            };

            oAutomobiles.ForEach(x => oContext.Automobiles.Add(x));
            oContext.SaveChanges();
        }
    }
}