using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VdiWeb.Core;
using VdiWeb.Data;

namespace VdiWeb.Pages
{
    public class EventsModel : PageModel
    {
        private readonly IEventData eventData;

        public IEnumerable<Event> Events { get; set; }
        public EventsModel(IEventData eventData)
        {
            this.eventData = eventData;
        }
        public void OnGet()
        {
            Events = eventData.GetAll();
        }
    }
}