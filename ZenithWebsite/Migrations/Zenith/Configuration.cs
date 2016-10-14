namespace ZenithWebsite.Migrations.Zenith
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithWebsite.Models.ZenithContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Zenith";
        }

        protected override void Seed(ZenithWebsite.Models.ZenithContext context)
        {
            context.Activities.AddOrUpdate(a => a.ActivityId, getActivities().ToArray());
            context.SaveChanges();

            context.Events.AddOrUpdate(e => e.EventId, getEvents(context).ToArray());
            context.SaveChanges();
        }

        private List<Activity> getActivities()
        {
            List<Activity> activities = new List<Activity>();
            activities.Add(new Activity()
            {
                Description  = "Senior's Golf Tournament",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Leadership General Assembly Meeting",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Youth Bowling Tournament",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Youth ladies cooking lessons",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Youth craft lessons",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Youth choir practice",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Lunch",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Pancake Breakfast",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Swimming lessons for youth",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Swimming exercise for parents",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Bingo Tournament",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "BBQ Lunch",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });
            activities.Add(new Activity()
            {
                Description = "Garage Sale",
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1)
            });

            return activities;
        }

        private List<Event> getEvents(ZenithContext db)
        {
            List<Event> events = new List<Event>();
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 09, 27, 8, 30, 0),
                DateTo = new DateTime(2016, 09, 27, 10, 30, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 1),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 09, 28, 8, 30, 0),
                DateTo = new DateTime(2016, 09, 28, 10, 30, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 2),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 09, 30, 17, 30, 0),
                DateTo = new DateTime(2016, 09, 30, 19, 15, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 3),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 09, 30, 19, 0, 0),
                DateTo = new DateTime(2016, 09, 30, 20, 0, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 4),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 1, 8, 30, 0),
                DateTo = new DateTime(2016, 10, 1, 10, 30, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 5),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 1, 10, 30, 0),
                DateTo = new DateTime(2016, 10, 1, 12, 0, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 6),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 1, 12, 0, 0),
                DateTo = new DateTime(2016, 10, 1, 13, 30, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 7),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 2, 7, 30, 0),
                DateTo = new DateTime(2016, 10, 2, 8, 30, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 8),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 2, 8, 30, 0),
                DateTo = new DateTime(2016, 10, 2, 10, 30, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 9),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 2, 8, 30, 0),
                DateTo = new DateTime(2016, 10, 2, 10, 30, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 10),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 2, 10, 30, 0),
                DateTo = new DateTime(2016, 10, 2, 12, 0, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 11),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 2, 12, 0, 0),
                DateTo = new DateTime(2016, 10, 2, 13, 0, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 12),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });
            events.Add(new Event()
            {
                DateFrom = new DateTime(2016, 10, 2, 13, 0, 0),
                DateTo = new DateTime(2016, 10, 2, 18, 0, 0),
                UserName = "a",
                Activity = db.Activities.First(a => a.ActivityId == 13),
                CreationDate = new DateTime(2016, 1, 1, 1, 1, 1),
                IsActive = true
            });

            return events;
        }
    }
}
