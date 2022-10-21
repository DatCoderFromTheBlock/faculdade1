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
    public class DisciplinasController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Disciplinas
        public ActionResult Index()
        {
            return View(db.Disciplinas.ToList());
        }

        // GET: Disciplinas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplinas.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // GET: Disciplinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disciplinas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DisciplinaID,nome")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                db.Disciplinas.Add(disciplina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(disciplina);
        }

        // GET: Disciplinas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplinas.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // POST: Disciplinas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DisciplinaID,nome")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disciplina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disciplina);
        }

        // GET: Disciplinas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplinas.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // POST: Disciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Disciplina disciplina = db.Disciplinas.Find(id);
            db.Disciplinas.Remove(disciplina);
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
