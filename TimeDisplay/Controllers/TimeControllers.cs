
using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class TimeController : Controller
    {

        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            ViewBag.CreatedOn = DateTime.Now;
            return View();
        }
    }
}