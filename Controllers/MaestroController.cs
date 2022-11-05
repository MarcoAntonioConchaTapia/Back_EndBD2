using Back_EndBD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_EndBD.Controllers
{
    public class MaestroController : Controller
    {
  public ActionResult Index2()
        {
            using(AlumnoDbContext maestroDb = new AlumnoDbContext())
            {
                //alumnoDbContext = MestroDbContext
                //dbAlumnos = dbMaestro
                return View(maestroDb.Maestro.ToList());
            }
            
        }

        public ActionResult Details2(int Id)
        {
            using (AlumnoDbContext maestroDb = new AlumnoDbContext())
            {
                Maestro maestros = maestroDb.Maestro.Find(Id);
                if(maestros == null)
                {
                    return HttpNotFound();
                }
                return View(maestros);
            }
        }

        public ActionResult Create2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create2(Maestro profe)
        {
            using (AlumnoDbContext maestroDb = new AlumnoDbContext())
            {
                maestroDb.Maestro.Add(profe);
                maestroDb.SaveChanges();
            }
            return RedirectToAction("Index2");
        }

        public ActionResult Edit2(int Id)
        {
            using (AlumnoDbContext maestroDb = new AlumnoDbContext())
            {
                return View(maestroDb.Maestro.Where(x=>x.Id==Id).FirstOrDefault());
            }
        }

       [HttpPost]

        public ActionResult Edit2(Maestro prof)
        {
            using (AlumnoDbContext maestroDb = new AlumnoDbContext())
            {
                maestroDb.Entry(prof).State = EntityState.Modified;
                maestroDb.SaveChanges();
            }
            return RedirectToAction("Index2");
        }


        public ActionResult Delete2(int? Id)
        {
            using (AlumnoDbContext maestroDb = new AlumnoDbContext())
            {
                return View(maestroDb.Maestro.Where(x => x.Id == Id).FirstOrDefault());
            }
        }

        [HttpPost]

        public ActionResult Delete2(Maestro prof, int Id)
        {
            using (AlumnoDbContext maestroDb = new AlumnoDbContext())
            {
                Maestro pro = maestroDb.Maestro.Where(x => x.Id == Id).FirstOrDefault();
                maestroDb.Maestro.Remove(pro);
                maestroDb.SaveChanges();
            }
            return RedirectToAction("Index2");
        }

    }
}