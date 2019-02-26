using System.Collections.Generic;
using System;
using WorldData.Models;
using Microsoft.AspNetCore.Mvc;

namespace WorldData.Controllers
{
    public class CityController : Controller
    {
        [HttpGet("/cities")]
        public ActionResult Index()
        {
            List<City> model = City.GetAllCities();
            return View(model); // DAVE
        }
    }
}