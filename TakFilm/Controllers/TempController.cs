using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakFilm.Models;

namespace TakFilm.Controllers
{
    public class TempController : Controller
    {
        // GET: Temp
        public ActionResult Ajax()
        {
            return View();
        }
        public ActionResult RowAjaxProcess(string name)
        {
            return Content("SAlAM");
        }
        public ActionResult MVCHelper()
        {
            return View();
        }
        public ActionResult AjaxActionLinkProcess()
        {
            return Content("SALAM");
        }
        public ActionResult DataTransfer()
        {
            ViewData["Name"] = "Leila";
            ViewBag.Age = 28;
            var movie = new Movie { Id = 1, Name = "Hangaver 3" };
            ViewData["movie"] = movie;
            ViewBag.selectMovie = movie;

            return View();
        }
    }
}