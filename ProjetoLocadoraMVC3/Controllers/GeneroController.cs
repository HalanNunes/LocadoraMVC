using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLocadoraMVC3.Models;

namespace ProjetoLocadoraMVC3.Controllers
{
    public class GeneroController : Controller
    {
        private LOCADORAEntities db = new LOCADORAEntities();

        //
        // GET: /Genero/

        public ActionResult Index()
        {
            return View(db.GENERO.ToList());
        }

        //
        // GET: /Genero/Details/5

        public ActionResult Details(long id = 0)
        {
            GENERO genero = db.GENERO.Find(id);
            if (genero == null)
            {
                return HttpNotFound();
            }
            return View(genero);
        }

        //
        // GET: /Genero/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Genero/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GENERO genero)
        {
            if (ModelState.IsValid)
            {
                db.GENERO.Add(genero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genero);
        }

        //
        // GET: /Genero/Edit/5

        public ActionResult Edit(long id = 0)
        {
            GENERO genero = db.GENERO.Find(id);
            if (genero == null)
            {
                return HttpNotFound();
            }
            return View(genero);
        }

        //
        // POST: /Genero/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GENERO genero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genero);
        }

        //
        // GET: /Genero/Delete/5

        public ActionResult Delete(long id = 0)
        {
            GENERO genero = db.GENERO.Find(id);
            if (genero == null)
            {
                return HttpNotFound();
            }
            return View(genero);
        }

        //
        // POST: /Genero/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            GENERO genero = db.GENERO.Find(id);
            db.GENERO.Remove(genero);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}