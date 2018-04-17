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
    public class QuestionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Questions
        public ActionResult Index()
        {
            //return View(db.ContactAdmins.ToList());
            

            return View();
        }

        // GET: Questions/Details/5
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

        // GET: Questions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questions/Create
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

        // GET: Questions/Edit/5
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

        // POST: Questions/Edit/5
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

        // GET: Questions/Delete/5
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

        // POST: Questions/Delete/5
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
