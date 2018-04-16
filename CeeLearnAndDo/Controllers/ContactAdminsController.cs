using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CeeLearnAndDo.Models;

namespace CeeLearnAndDo.Controllers
{
    public class ContactAdminsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ContactAdmins
        public ActionResult Index()
        {
            return View(db.ContactAdmins.ToList());
        }

        // GET: ContactAdmins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactAdmin contactAdmin = db.ContactAdmins.Find(id);
            if (contactAdmin == null)
            {
                return HttpNotFound();
            }
            return View(contactAdmin);
        }

        // GET: ContactAdmins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactAdmins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Name,Title,Description,Type")] ContactAdmin contactAdmin)
        {
            if (ModelState.IsValid)
            {
                db.ContactAdmins.Add(contactAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactAdmin);
        }

        // GET: ContactAdmins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactAdmin contactAdmin = db.ContactAdmins.Find(id);
            if (contactAdmin == null)
            {
                return HttpNotFound();
            }
            return View(contactAdmin);
        }

        // POST: ContactAdmins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Name,Title,Description,Type")] ContactAdmin contactAdmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactAdmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactAdmin);
        }

        // GET: ContactAdmins/Answer/5
        public ActionResult Answer(int? id)
        {
            if (id == null)
            {
               return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnswerViewModel model = new AnswerViewModel()
            {
                contactadmin = db.ContactAdmins.Find(id)
            };
            
            if (model.contactadmin == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: ContactAdmins/Answer/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Answer([Bind(Include = "Id,QuestionId,AnswerDescription,SiteDisplay")] Answer answer)
        {
            var test = answer;
            if (ModelState.IsValid)
            {
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(answer);
        }
    

        // GET: ContactAdmins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactAdmin contactAdmin = db.ContactAdmins.Find(id);
            if (contactAdmin == null)
            {
                return HttpNotFound();
            }
            return View(contactAdmin);
        }

        // POST: ContactAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactAdmin contactAdmin = db.ContactAdmins.Find(id);
            db.ContactAdmins.Remove(contactAdmin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
