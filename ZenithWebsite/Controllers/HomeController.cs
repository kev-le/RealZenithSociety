using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;
using ZenithWebsite.Models;

namespace ZenithWebsite.Controllers
{
    public class HomeController : Controller
    {
        private ZenithContext db = new ZenithContext();
        public ActionResult Index()
        {
            var rawEvents = db.Events.Include(e => e.Activity).ToList();
            var events = new Dictionary<String, List<Event>>();
            foreach (var e in rawEvents)
            {
                if (events.ContainsKey(e.DateFrom.ToLongDateString()))
                {
                    events[e.DateFrom.ToLongDateString()].Add(e);
                }
                else
                {
                    events[e.DateFrom.ToLongDateString()] = new List<Event>();
                    events[e.DateFrom.ToLongDateString()].Add(e);
                }
            }
            return View(events);
            //return View();
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
    }
}