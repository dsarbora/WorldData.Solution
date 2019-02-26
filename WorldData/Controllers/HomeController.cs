using System;
using Microsoft.AspNetCore.Mvc;
using WorldData.Models;

namespace WorldDate.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}