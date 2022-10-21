using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using faculdade1.DAL;
using faculdade1.Models;

namespace faculdade1.Controllers
{
    public class DisciplinasAssociadasController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: DisciplinasAssociadas
        public ActionResult Index()
        {
            return View(db.DisciplinasAssociadas.ToList());
        }

        // GET: DisciplinasAssociadas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DisciplinasAssociadas disciplinasAssociadas = db.DisciplinasAssociadas.Find(id);
            if (disciplinasAssociadas == null)
            {
                return HttpNotFound();
            }
            return View(disciplinasAssociadas);
        }

        // GET: DisciplinasAssociadas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DisciplinasAssociadas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] DisciplinasAssociadas disciplinasAssociadas)
        {
            if (ModelState.IsValid)
            {
                db.DisciplinasAssociadas.Add(disciplinasAssociadas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(disciplinasAssociadas);
        }

        // GET: DisciplinasAssociadas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DisciplinasAssociadas disciplinasAssociadas = db.DisciplinasAssociadas.Find(id);
            if (disciplinasAssociadas == null)
            {
                return HttpNotFound();
            }
            return View(disciplinasAssociadas);
        }

        // POST: DisciplinasAssociadas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] DisciplinasAssociadas disciplinasAssociadas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disciplinasAssociadas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disciplinasAssociadas);
        }

        // GET: DisciplinasAssociadas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DisciplinasAssociadas disciplinasAssociadas = db.DisciplinasAssociadas.Find(id);
            if (disciplinasAssociadas == null)
            {
                return HttpNotFound();
            }
            return View(disciplinasAssociadas);
        }

        // POST: DisciplinasAssociadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DisciplinasAssociadas disciplinasAssociadas = db.DisciplinasAssociadas.Find(id);
            db.DisciplinasAssociadas.Remove(disciplinasAssociadas);
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
