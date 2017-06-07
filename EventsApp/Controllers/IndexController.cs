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
            var entity = new EventsEntity();
            var myEvents =  entity.MyEvents.Where( x => x.EventDate > DateTime.Now).ToList();
            //index page wants to retun a countdown list of my current events
            //countdown only inlcudes name and how long until the event
            //want to be able to click on the event to open more details on that event
            //details should include the name, date/time, description
            //button on the page for adding a new event
            //each 'event tile' should have an edit/delete icon
            return View(myEvents);
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var entity = new EventsEntity();
            var eventId = entity.MyEvents.Where(x => x.EventId == id).First();

            return View(eventId);
        }

        [HttpPost]
        public ActionResult Edit(MyEvent changedEvent)
        {
            var entity = new EventsEntity();
            var eventId = entity.MyEvents.Attach(changedEvent);
            entity.Entry(changedEvent).State = System.Data.Entity.EntityState.Modified;
            entity.SaveChanges();
            return RedirectToAction("Index");
        }
    }   
}