using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ew774515_MIS4800.DAL;
using ew774515_MIS4800.Models;

namespace ew774515_MIS4800.Controllers
{
    public class vetsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: vets
        public ActionResult Index()
        {
            return View(db.Vets.ToList());
        }

        // GET: vets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vets vets = db.Vets.Find(id);
            if (vets == null)
            {
                return HttpNotFound();
            }
            return View(vets);
        }

        // GET: vets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vetsID,vetsLastName,vetsFirstName,email,phone,vetSince")] vets vets)
        {
            if (ModelState.IsValid)
            {
                db.Vets.Add(vets);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vets);
        }

        // GET: vets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vets vets = db.Vets.Find(id);
            if (vets == null)
            {
                return HttpNotFound();
            }
            return View(vets);
        }

        // POST: vets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vetsID,vetsLastName,vetsFirstName,email,phone,vetSince")] vets vets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vets).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vets);
        }

        // GET: vets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vets vets = db.Vets.Find(id);
            if (vets == null)
            {
                return HttpNotFound();
            }
            return View(vets);
        }

        // POST: vets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vets vets = db.Vets.Find(id);
            db.Vets.Remove(vets);
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
