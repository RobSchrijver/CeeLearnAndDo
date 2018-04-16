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
    public class ReferencesController : Controller
    {
        // GET: References
        public ActionResult Create()
        {
            return View();
        }
    
        // POST: Reference/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Info,Image")] Reference reference)
        {
            if (ModelState.IsValid)
            {
                db.References.Add(reference);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reference);
        }
    }
}