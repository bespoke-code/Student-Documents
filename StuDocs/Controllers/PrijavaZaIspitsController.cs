using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StuDocs.Models;

namespace StuDocs.Controllers
{
    public class PrijavaZaIspitsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PrijavaZaIspits
        public ActionResult Index()
        {
            return View(db.PrijavaZaIspits.ToList());
        }

        // GET: PrijavaZaIspits/Details/5
        public ActionResult Details() //string id
        {
            PrijavaZaIspit prijavaZaIspit = TempData["prijava"] as PrijavaZaIspit;
            Student student = TempData["Student"] as Student;

            TempData["Student"] = student;
            TempData["prijava"] = prijavaZaIspit;

            if (prijavaZaIspit == null)
            {
                return HttpNotFound();
            }
            return View(prijavaZaIspit);
        }

        // GET: PrijavaZaIspits/Create
        public ActionResult Create()
        {
            Student student = TempData["Student"] as Student;
            return View();
        }

        public ActionResult Print()
        {
            PrijavaStudent prijava = new PrijavaStudent();
            prijava.p = TempData["prijava"] as PrijavaZaIspit;
            prijava.s = TempData["student"] as Student;
            return View(prijava);
        }

        // POST: PrijavaZaIspits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "iknowBroj,faculty,ciklus,programa,modul,ispitenRok,predmet,kod,semestar,polaganje,prof,assistant,adminTaksa")] PrijavaZaIspit prijavaZaIspit)
        {
            if (ModelState.IsValid)
            {
                Student student = TempData["student"] as Student;

                TempData["student"] = student;
                TempData["prijava"] = prijavaZaIspit;

                return RedirectToAction("Details");
            }
            return View(prijavaZaIspit);
        }

        // GET: PrijavaZaIspits/Edit/5
        public ActionResult Edit() //string id
        {
            Student student = TempData["student"] as Student;
            PrijavaZaIspit prijavaZaIspit = TempData["prijava"] as PrijavaZaIspit;
            if (prijavaZaIspit.iknowBroj == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (prijavaZaIspit == null)
            {
                return HttpNotFound();
            }
            TempData["student"] = student;
            TempData["prijava"] = prijavaZaIspit;
            return View(prijavaZaIspit);
        }

        // POST: PrijavaZaIspits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iknowBroj,faculty,ciklus,programa,modul,ispitenRok,predmet,kod,semestar,polaganje,prof,assistant,adminTaksa")] PrijavaZaIspit prijavaZaIspit)
        {
            Student student = TempData["student"] as Student;
            if (ModelState.IsValid)
            {
                
                TempData["prijava"] = prijavaZaIspit;
                return RedirectToAction("Details");
            }
            TempData["student"] = student;
            return View(prijavaZaIspit);
        }

















        //----------------------------------------------------------------------------------------

        // GET: PrijavaZaIspits/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrijavaZaIspit prijavaZaIspit = db.PrijavaZaIspits.Find(id);
            if (prijavaZaIspit == null)
            {
                return HttpNotFound();
            }
            return View(prijavaZaIspit);
        }

        // POST: PrijavaZaIspits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PrijavaZaIspit prijavaZaIspit = db.PrijavaZaIspits.Find(id);
            db.PrijavaZaIspits.Remove(prijavaZaIspit);
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
