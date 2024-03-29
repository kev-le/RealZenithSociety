﻿using System;
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
            var monday = DateTime.Today.AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 1);
            var sunday = DateTime.Today.AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 8);

            var rawEvents = db.Events.Include(e => e.Activity);
            rawEvents = rawEvents.Where(e => e.DateFrom >= monday && e.DateTo <= sunday)
                                 .OrderBy(c => c.DateFrom);
            var events = new Dictionary<String, List<Event>>();
            foreach (var e in rawEvents)
            {
                if (e.IsActive)
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
            }
            ViewBag.WeekOf = monday.ToLongDateString();
            return View(events);
        }
        
    }
}