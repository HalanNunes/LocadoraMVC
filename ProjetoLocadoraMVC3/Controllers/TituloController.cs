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
    public class TituloController : Controller
    {
        private LOCADORAEntities db = new LOCADORAEntities();

        //
        // GET: /Titulo/

        public ActionResult Index()
        {
            var titulo = db.TITULO.Include(t => t.TIPO_TITULO);
            return View(titulo.ToList());
        }

        //
        // GET: /Titulo/Details/5

        public ActionResult Details(long id = 0)
        {
            TITULO titulo = db.TITULO.Find(id);
            if (titulo == null)
            {
                return HttpNotFound();
            }
            return View(titulo);
        }

        //
        // GET: /Titulo/Create

        public ActionResult Create()
        {
            ViewBag.CD_TIPO_TITULO = new SelectList(db.TIPO_TITULO, "CD_TIPO_TITULO", "DS_TIPO_TITULO");
            return View();
        }

        //
        // POST: /Titulo/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TITULO titulo)
        {
            if (ModelState.IsValid)
            {
                db.TITULO.Add(titulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CD_TIPO_TITULO = new SelectList(db.TIPO_TITULO, "CD_TIPO_TITULO", "DS_TIPO_TITULO", titulo.CD_TIPO_TITULO);
            return View(titulo);
        }

        //
        // GET: /Titulo/Edit/5

        public ActionResult Edit(long id = 0)
        {
            TITULO titulo = db.TITULO.Find(id);
            if (titulo == null)
            {
                return HttpNotFound();
            }
            ViewBag.CD_TIPO_TITULO = new SelectList(db.TIPO_TITULO, "CD_TIPO_TITULO", "DS_TIPO_TITULO", titulo.CD_TIPO_TITULO);
            return View(titulo);
        }

        //
        // POST: /Titulo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TITULO titulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(titulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CD_TIPO_TITULO = new SelectList(db.TIPO_TITULO, "CD_TIPO_TITULO", "DS_TIPO_TITULO", titulo.CD_TIPO_TITULO);
            return View(titulo);
        }

        //
        // GET: /Titulo/Delete/5

        public ActionResult Delete(long id = 0)
        {
            TITULO titulo = db.TITULO.Find(id);
            if (titulo == null)
            {
                return HttpNotFound();
            }
            return View(titulo);
        }

        //
        // POST: /Titulo/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TITULO titulo = db.TITULO.Find(id);
            db.TITULO.Remove(titulo);
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