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
    public class AtorController : Controller
    {
        private LOCADORAEntities db = new LOCADORAEntities();

        //
        // GET: /Ator/

        public ActionResult Index()
        {
            return View(db.ATOR.ToList());
        }

        //
        // GET: /Ator/Details/5

        public ActionResult Details(long id = 0)
        {
            ATOR ator = db.ATOR.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        //
        // GET: /Ator/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ator/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ATOR ator)
        {
            if (ModelState.IsValid)
            {
                db.ATOR.Add(ator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ator);
        }

        //
        // GET: /Ator/Edit/5

        public ActionResult Edit(long id = 0)
        {
            ATOR ator = db.ATOR.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        //
        // POST: /Ator/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ATOR ator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ator);
        }

        //
        // GET: /Ator/Delete/5

        public ActionResult Delete(long id = 0)
        {
            ATOR ator = db.ATOR.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        //
        // POST: /Ator/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ATOR ator = db.ATOR.Find(id);
            db.ATOR.Remove(ator);
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