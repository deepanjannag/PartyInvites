using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvitesCovid.Models;

namespace PartyInvitesCovid.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good MOrning!" : "Good Afternoon";
            return View("MyView");
        }
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
