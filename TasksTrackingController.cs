using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasskTracking.Models;

namespace TasskTracking.Controllers
{
    public class TasksTrackingController : Controller
    {
        //
        ApplicationDbContext dn = new ApplicationDbContext();
        // GET: /TasksTracking/
        public ActionResult Index()
        {
            return View(dn.Task_Tracking.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.priority = new SelectList(new[] { "High", "Medium", "Low" });
            ViewBag.statue = new SelectList(new[] { "Open", "Deferred", "Fixed", "Closed" });
            return View();
        }
        [HttpPost]
        public ActionResult Create(Task_Tracking task)
        {
          if(ModelState.IsValid){

              dn.Task_Tracking.Add(task);
              dn.SaveChanges();
              return RedirectToAction("Index");
          }

            return View(task);
        }

        public ActionResult Details(int id)
        {
            
            Task_Tracking task = dn.Task_Tracking.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            
            }
            return View(task);
        }

	}
}