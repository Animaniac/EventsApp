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

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var entity = new EventsEntity();
            var eventId = entity.MyEvents.Where(x => x.EventId == id).First();

            return View(eventId);
        }
        [HttpPost]
        public ActionResult Delete(MyEvent eventToDelete)
        {
            var entity = new EventsEntity();
            var currentEvent = entity.MyEvents.Where(x => x.EventId == eventToDelete.EventId).First();
            entity.MyEvents.Remove(currentEvent);            
            entity.SaveChanges();
            return RedirectToAction("Index");
        }
    }   
}