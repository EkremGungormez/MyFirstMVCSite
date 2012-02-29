using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCProject.Models;

namespace MyFirstMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() 
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            

            return View(); 
        }
        
        [HttpGet]
        public ViewResult RSVPForm() 
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if (@ModelState.IsValid) 
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

    }
}
