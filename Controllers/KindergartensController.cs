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
    public class KindergartensController : Controller
    {
        private kindergartenContainer1 db = new kindergartenContainer1();

        // GET: Kindergartens
        public ActionResult Index()
        {
            var a = "MELBOURNE";
            var kindergartens = db.KindergartenSet.Where(r => ((r.Suburb).Contains(a)) == true);
            return View(kindergartens.ToList());

        }
     

        public ActionResult Update_table(string input_area)
        {

            if (input_area == "")
            {
                var ab = "MELBOURNE";
                var kindergartens1 = db.KindergartenSet.Where(r => ((r.Suburb).Contains(ab)) == true);
                return View(kindergartens1.ToList());

            }
            else
            {
                var a = input_area;
                var kindergartens = db.KindergartenSet.Where(r => (((r.Suburb).Replace(" ","")).Contains(a.Replace(" ", "")) || (r.Postcode).Contains(a)) == true);
                return View(kindergartens.ToList());
            }

        }



        // GET: Kindergartens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kindergarten kindergarten = db.KindergartenSet.Find(id);
            if (kindergarten == null)
            {
                return HttpNotFound();
            }
            return View(kindergarten);
        }

        // GET: Kindergartens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kindergartens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ServiceName,Address,Suburb,Postcode,Phone,Email_Address,location")] Kindergarten kindergarten)
        {
            if (ModelState.IsValid)
            {
                db.KindergartenSet.Add(kindergarten);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kindergarten);
        }

        // GET: Kindergartens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kindergarten kindergarten = db.KindergartenSet.Find(id);
            if (kindergarten == null)
            {
                return HttpNotFound();
            }
            return View(kindergarten);
        }

        // POST: Kindergartens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ServiceName,Address,Suburb,Postcode,Phone,Email_Address,location")] Kindergarten kindergarten)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kindergarten).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kindergarten);
        }

        // GET: Kindergartens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kindergarten kindergarten = db.KindergartenSet.Find(id);
            if (kindergarten == null)
            {
                return HttpNotFound();
            }
            return View(kindergarten);
        }

        // POST: Kindergartens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kindergarten kindergarten = db.KindergartenSet.Find(id);
            db.KindergartenSet.Remove(kindergarten);
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
