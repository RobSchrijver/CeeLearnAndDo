using CeeLearnAndDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CeeLearnAndDo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactAdmin contact)
        {
            ApplicationDbContext db = new ApplicationDbContext();
 
            db.ContactAdmins.Add(contact);
            db.SaveChanges();

            return View();
        }

        public ActionResult Answer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Answer(Answer answer)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            db.Answers.Add(answer);
            db.SaveChanges();

            return View();
        }
    }
}