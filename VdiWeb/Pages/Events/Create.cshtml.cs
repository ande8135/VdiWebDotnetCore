using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VdiWeb.Core;

namespace VdiWeb.Pages.Events
{
    public class CreateModel : PageModel
    {
        public Event Event { get; set; }

        public CreateModel(object @event)
        {
            Event = (Event)@event;
        }

        public CreateModel()
        {
            Event = new Event();
        }
        public void OnGet()
        {

        }
    }
}