using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsApp.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            //index page wants to retun a countdown list of my current events
            //countdown only inlcudes name and how long until the event
            //want to be able to click on the event to open more details on that event
            //details should include the name, date/time, description
            //button on the page for adding a new event
            //each 'event tile' should have an edit/delete icon
            return View();
        }
    }
}