using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SalesPersonController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: SalesPerson
        public ActionResult Index()
        {
            return View(db.SalesPeople.ToList());
        }

        // GET: SalesPerson/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesPerson salesPerson = db.SalesPeople.Find(id);
            if (salesPerson == null)
            {
                return HttpNotFound();
            }
            return View(salesPerson);
        }

        // GET: SalesPerson/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesPerson/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Commission")] SalesPerson salesPerson)
        {
            if (ModelState.IsValid)
            {
                db.SalesPeople.Add(salesPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesPerson);
        }

        // GET: SalesPerson/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesPerson salesPerson = db.SalesPeople.Find(id);
            if (salesPerson == null)
            {
                return HttpNotFound();
            }
            return View(salesPerson);
        }

        // POST: SalesPerson/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Commission")] SalesPerson salesPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salesPerson);
        }

        // GET: SalesPerson/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesPerson salesPerson = db.SalesPeople.Find(id);
            if (salesPerson == null)
            {
                return HttpNotFound();
            }
            return View(salesPerson);
        }

        // POST: SalesPerson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesPerson salesPerson = db.SalesPeople.Find(id);
            db.SalesPeople.Remove(salesPerson);
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
