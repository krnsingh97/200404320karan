using _200404320karan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200404320karan.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult mycar()
        {
            Gaddi alex = new Gaddi();
            alex.FirstName = "alws";
            alex.LastName = " daawd";
       
            return View();
        }
    }
}