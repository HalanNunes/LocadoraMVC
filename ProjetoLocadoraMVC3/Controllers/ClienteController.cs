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
    public class ClienteController : Controller
    {
        private LOCADORAEntities db = new LOCADORAEntities();

        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(db.CLIENTE.ToList());
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(long id = 0)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                db.CLIENTE.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(long id = 0)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(long id = 0)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            db.CLIENTE.Remove(cliente);
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