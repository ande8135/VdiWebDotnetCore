using System;
using System.Collections.Generic;
using System.Text;

namespace VdiWeb.Core
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset EventDateTime { get; set; }
        public Address Location { get; set; }
        public Dictionary<string, Uri> BandsInfo { get; set; }

    }
}
