using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmotionPlatziWeb.Models;

namespace EmotionPlatziWeb.Controllers
{
    public class EmoPicturesController : Controller
    {
        private EmotionPlatziWebContext db = new EmotionPlatziWebContext();

        // GET: EmoPictures
        public ActionResult Index()
        {
            return View(db.EmoPicture.ToList());
        }

        // GET: EmoPictures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmoPicture emoPicture = db.EmoPicture.Find(id);
            if (emoPicture == null)
            {
                return HttpNotFound();
            }
            return View(emoPicture);
        }

        // GET: EmoPictures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmoPictures/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nombre,path,CreateDate")] EmoPicture emoPicture)
        {
            if (ModelState.IsValid)
            {
                db.EmoPicture.Add(emoPicture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emoPicture);
        }

        // GET: EmoPictures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmoPicture emoPicture = db.EmoPicture.Find(id);
            if (emoPicture == null)
            {
                return HttpNotFound();
            }
            return View(emoPicture);
        }

        // POST: EmoPictures/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nombre,path,CreateDate")] EmoPicture emoPicture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emoPicture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emoPicture);
        }

        // GET: EmoPictures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmoPicture emoPicture = db.EmoPicture.Find(id);
            if (emoPicture == null)
            {
                return HttpNotFound();
            }
            return View(emoPicture);
        }

        // POST: EmoPictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmoPicture emoPicture = db.EmoPicture.Find(id);
            db.EmoPicture.Remove(emoPicture);
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
