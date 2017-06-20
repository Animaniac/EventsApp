using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsApp
{
    public partial class MyEvent
    {
        public string HumanizedDateTime
        {
            get
            {
                var nowDateTime = DateTime.Now;
                var timeToEvent = EventDate - nowDateTime;
                return timeToEvent.Humanize(4);
            }
        }
    }
}