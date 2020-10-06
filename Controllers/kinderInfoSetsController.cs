using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using v2.Models;

namespace v2.Controllers
{
    public class kinderInfoSetsController : Controller
    {
        private Model1 db = new Model1();

        // GET: kinderInfoSets
        public ActionResult Index(string input_area)
        {


         


            if (input_area == null)
            {
                var a = "MELBOURNE";
                var kindergartens = db.kinderInfoSets.Where(r => ((r.Suburb).Contains(a)) == true);
                return View(kindergartens.ToList());
            }
            else
            {
                var b = input_area;
                var kindergartens1 = db.kinderInfoSets.Where(r => (((r.Suburb).Replace(" ", "")).Contains(b.Replace(" ", "")) || (r.PostCode).Contains(b)) == true);
                return View(kindergartens1.ToList());
            }


        }

      





        public ActionResult Update_table(string input_area)
        {

            if (input_area == "")
            {
                var a = "MELBOURNE";
                var kindergartens = db.kinderInfoSets.Where(r => ((r.Suburb).Contains(a)) == true);
                return View(kindergartens.ToList());

            }
            else
            {
                var a = input_area;
                var kindergartens = db.kinderInfoSets.Where(r => (((r.Suburb).Replace(" ", "")).Contains(a.Replace(" ", "")) || (r.PostCode).Contains(a)) == true);
                return View(kindergartens.ToList());
            }

        }


        // GET: kinderInfoSets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kinderInfoSet kinderInfoSet = db.kinderInfoSets.Find(id);
            if (kinderInfoSet == null)
            {
                return HttpNotFound();
            }
            return View(kinderInfoSet);
        }

        // GET: kinderInfoSets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: kinderInfoSets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Type,PostCode,Suburb,Email,Rating,Address,Location")] kinderInfoSet kinderInfoSet)
        {
            if (ModelState.IsValid)
            {
                db.kinderInfoSets.Add(kinderInfoSet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kinderInfoSet);
        }

        // GET: kinderInfoSets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kinderInfoSet kinderInfoSet = db.kinderInfoSets.Find(id);
            if (kinderInfoSet == null)
            {
                return HttpNotFound();
            }
            return View(kinderInfoSet);
        }

        // POST: kinderInfoSets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Type,PostCode,Suburb,Email,Rating,Address,Location")] kinderInfoSet kinderInfoSet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kinderInfoSet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kinderInfoSet);
        }

        // GET: kinderInfoSets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kinderInfoSet kinderInfoSet = db.kinderInfoSets.Find(id);
            if (kinderInfoSet == null)
            {
                return HttpNotFound();
            }
            return View(kinderInfoSet);
        }

        // POST: kinderInfoSets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kinderInfoSet kinderInfoSet = db.kinderInfoSets.Find(id);
            db.kinderInfoSets.Remove(kinderInfoSet);
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
