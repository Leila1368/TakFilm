using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TakFilm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        [ActionName("Contact")]
        public ActionResult ProcessForm(string firstName,
            string lastName,
            string password,
            string address,
            bool agreement,
            string gender,
            int city,
            int fruits,
            DateTime currentTime)
        {
            ViewBag.Message = "SALAM " + firstName + " - " + lastName;

            return View();
        }
    }
}