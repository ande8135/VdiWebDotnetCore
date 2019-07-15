using System;
using System.Collections.Generic;
using System.Text;
using VdiWeb.Core;

namespace VdiWeb.Data
{
    public class InMemoryEventData : IEventData
    {
        private List<Event> events;

        public InMemoryEventData()
        {
            events = new List<Event>()
            {
                new Event()
                {
                     Id = 1,
                     EventDateTime = new DateTimeOffset(new DateTime(2019, 8, 24, 21, 0, 0)),
                     Name = "Northern Wisconsin Metalfest",
                     Location = new Address()
                     {
                         City = "Lake Nebagamon",
                         Line1 = "1234 Show Rd.",
                         Line2 = "",
                         SiteName = "Wasko's Campground Plus",
                         State = "WI",
                         Zip = "54803"
                     },
                      BandsInfo = new Dictionary<string, Uri>()
                      {
                          { "Volcano Diving Inc.", new Uri("http://volcanodiving.com") },
                          { "Karma Sutra", new Uri("http://karmasutra.com") },
                          { "Redshift", new Uri("http://redshift.com") }
                      }
                },
                new Event()
                {
                     Id = 2,
                     EventDateTime = new DateTimeOffset(new DateTime(2019, 8, 15, 21, 0, 0)),
                     Name = "Super Awesome Music Festival",
                     Location = new Address()
                     {
                         City = "Atlanta",
                         Line1 = "1 Motor Speedway St.",
                         Line2 = "",
                         SiteName = "Atlanta Motor Speedway",
                         State = "GA",
                         Zip = "90210"
                     },
                      BandsInfo = new Dictionary<string, Uri>()
                      {
                          { "Chromeo", new Uri("http://lizzo.com") },
                          { "Seven Lions", new Uri("http://sevenlions.com") },
                          { "The Glitch Mob", new Uri("http://wubwub.com") }
                      }
                }
            };
        }

        public IEnumerable<Event> GetAll()
        {
            return events;
        }
    }
}
