using Modifiers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modifiers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Car myCar = new Car();
            //var moveReturn = myCar.move();
            myCar.setWheels(4);
            myCar.passenger.name = "Alex";
            int wheels = myCar.getWheels();
            myCar.license = "523";
            Plane myPlane = new Plane();
            List<Vehicle> myVehicles = new List<Vehicle>(){
                myCar,
                myPlane
            };

            return View(myVehicles);
        }

        public ActionResult About()
        {
            int sum = NewMath.add(9, 4);
            NewMath.someProp = 10;
            ViewBag.Message = "Your application description page.";

            return View(NewMath.someProp);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(NewMath.someProp);
        }
    }
}