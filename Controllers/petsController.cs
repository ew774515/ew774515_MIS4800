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
    public class petsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: pets
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }

        // GET: pets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pets pets = db.Pets.Find(id);
            if (pets == null)
            {
                return HttpNotFound();
            }
            return View(pets);
        }

        // GET: pets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "petsID,petsLastName,petsFirstName,email,phone,petsType,petsAge,patientSince")] pets pets)
        {
            if (ModelState.IsValid)
            {
                db.Pets.Add(pets);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pets);
        }

        // GET: pets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pets pets = db.Pets.Find(id);
            if (pets == null)
            {
                return HttpNotFound();
            }
            return View(pets);
        }

        // POST: pets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "petsID,petsLastName,petsFirstName,email,phone,petsType,petsAge,patientSince")] pets pets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pets).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pets);
        }

        // GET: pets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pets pets = db.Pets.Find(id);
            if (pets == null)
            {
                return HttpNotFound();
            }
            return View(pets);
        }

        // POST: pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pets pets = db.Pets.Find(id);
            db.Pets.Remove(pets);
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
