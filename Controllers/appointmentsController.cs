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
    public class appointmentsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: appointments
        public ActionResult Index()
        {
            var appointments = db.Appointments.Include(a => a.Pets).Include(a => a.Vets);
            return View(appointments.ToList());
        }

        // GET: appointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointments appointments = db.Appointments.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            return View(appointments);
        }

        // GET: appointments/Create
        public ActionResult Create()
        {
            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petsLastName");
            ViewBag.vetsID = new SelectList(db.Vets, "vetsID", "vetsLastName");
            return View();
        }

        // POST: appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointmentsID,appointmentsPrice,appointmentsDescription,petsID,vetsID")] appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Appointments.Add(appointments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petsLastName", appointments.petsID);
            ViewBag.vetsID = new SelectList(db.Vets, "vetsID", "vetsLastName", appointments.vetsID);
            return View(appointments);
        }

        // GET: appointments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointments appointments = db.Appointments.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petsLastName", appointments.petsID);
            ViewBag.vetsID = new SelectList(db.Vets, "vetsID", "vetsLastName", appointments.vetsID);
            return View(appointments);
        }

        // POST: appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointmentsID,appointmentsPrice,appointmentsDescription,petsID,vetsID")] appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petsLastName", appointments.petsID);
            ViewBag.vetsID = new SelectList(db.Vets, "vetsID", "vetsLastName", appointments.vetsID);
            return View(appointments);
        }

        // GET: appointments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointments appointments = db.Appointments.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            return View(appointments);
        }

        // POST: appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            appointments appointments = db.Appointments.Find(id);
            db.Appointments.Remove(appointments);
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
