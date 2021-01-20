using MVC3101.DAL;
using MVC3101.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3101.Controllers
{
    public class LjudiController : Controller
    {
        


        private PopisDBContext _db= new PopisDBContext();
        

        // GET: Ljudi
        public ActionResult PregledOsoba()
        {
            
            return View(_db._dbO.ToList());
        }

        public ActionResult DodajOsobu()
        {
            return View();  
        }

        [HttpPost]
    public ActionResult DodajOsobu(Osoba o)
        {
           

           
            //if (ModelState.IsValid)
            //{
                _db._dbO.Add(o);
                _db.SaveChanges();
                ViewBag.uredu = "Osoba je dodana";
                return RedirectToAction("PregledOsoba");
            //}
            //else
            //{
            //    ViewBag.greska = "Doslo je do pogreske";
            //    return View();
            //}
            
        }
        //GET promijeni
        public ActionResult Promijeni(int? id)
        {
            var osoba = _db._dbO.Where(o => o.ID == id).FirstOrDefault();
            return View(osoba);
        }

        [HttpPost]
        public ActionResult Promijeni(Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(osoba).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("PregledOsoba");
            }
            return View(osoba);
            
        }
        public ActionResult Izbrisi(int? id)
        {
            var osoba = _db._dbO.Where(o => o.ID == id).FirstOrDefault();

            //Osoba osoba = _db._dbO.Find(ID);
            _db._dbO.Remove(osoba);
            _db.SaveChanges();
            ViewBag.izbrisano = "Osoba je uspjesno izbrisana";
            return RedirectToAction("PregledOsoba");
        }
       
        //[HttpPost]
        //public ActionResult Izbrisi (int? id)
        //{
        //    var osoba = _db._dbO.Where(o => o.ID == id).FirstOrDefault();
            
        //    //Osoba osoba = _db._dbO.Find(ID);
        //    _db._dbO.Remove(osoba);
        //    _db.SaveChanges();
        //    ViewBag.izbrisano = "Osoba je uspjesno izbrisana";
        //    return RedirectToAction("PregledOsoba");
        //}

        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Movie movie = db.Movies.Find(id);
        //    if (movie == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(movie);
        //}











    }

    
}