using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      int hour = DateTime.Now.Hour;
      ViewBag.Hour = hour;
      ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
      ViewBag.Email = "test@example.com";
      return View();
    }
  }
}