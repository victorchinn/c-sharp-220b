using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVC_Basic.Controllers
{
    public class HomeController : Controller
    {
        //        // GET: Home
        //        public string Index()
        //        {
        //            return "Hello World";
        //        }
        //
        //        public IActionResult Index()
        //        {
        //            return View();
        //        }
        //
        //        public IActionResult RsvpForm()
        //        {
        //            return View();
        //        }


        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(Models.GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }


    }
}
