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
    public class StudentsController : Controller
    {

        // GET: Students/Details/5
        public ActionResult Details() //Student st
        {
            Student s = TempData["Student"] as Student;
            return View(s);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, specific properties you want to bind to are enabled
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "embg,name,surname,parentName,email,nationality,birthAddress,homeAddress,birthDate,phone")] Student stud)
        {
            TempData["Student"] = stud;
            if(stud.embg == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            else
                return RedirectToAction("Details"); //, new { s = stud }
        }

        // GET: Students/Edit/5
        public ActionResult Edit() //Student s
        {
            Student s = TempData["Student"] as Student;
            if (s.embg == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "embg,name,surname,parentName,email,nationality,birthAddress,homeAddress,birthDate,phone")] Student stud)
        {
            TempData["Student"] = stud;

            return RedirectToAction("Details"); //, new { s = stud }

        }



        //------------------------------------------------------------------------------------------

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: Students/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
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
