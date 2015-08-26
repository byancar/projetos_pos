using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Acmecurso.Controllers
{
    public class EstudanteController : Controller
    {
        private Models.ApplicationDbContext db = new Models.ApplicationDbContext();
        public ActionResult Index()
        {
            List<Models.Estudante> estudantes = db.Estudante.ToList();
            
            return View(estudantes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Models.Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Estudante.Add (estudante);
                db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(estudante);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        /*
        public ActionResult Edit(int? id)
        {
            return View();
        }
        */

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Models.Estudante estudante = db.Estudante.Find(id);
            if(estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estudante);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Models.Estudante estudante = db.Estudante.Find(id);

            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);

        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Models.Estudante estudante = db.Estudante.Find(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {

            Models.Estudante estudante = db.Estudante.Find(id);
            db.Estudante.Remove(estudante);
            db.SaveChanges();
            return RedirectToAction("Index");
           
        }


    }
}