using System.Collections.Generic;
using VdiWeb.Core;

namespace VdiWeb.Data
{
    public interface IEventData
    {
        IEnumerable<Event> GetAll();
    }
}