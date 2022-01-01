using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    public class AdweyaController : Controller
    {


            private myDBcontext _context;
            public AdweyaController(myDBcontext context)
            {

                _context = context;

            }

            protected override void Dispose(bool disposing)
            {
                _context.Dispose();
            }
            // GET: AdweyaControllercs
          public ActionResult Index()  
        {
            ViewBag.adweya = _context.aDweyas.ToList();
            return View();
        }

       

        // GET: AdweyaControllercs/Details/5
        public ActionResult Details(int id)
        {

            var tb = _context.aDweyas.Where(e => e.id_adweya == id).SingleOrDefault();

            return View(tb);
        }
       

        // GET: AdweyaControllercs/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ADweya aDweya)
        {
           
                if (ModelState.IsValid)
                {
                    _context.aDweyas.Add(aDweya);
                    _context.SaveChanges();

                }

                return RedirectToAction(nameof(Index));
           
        }

        // GET: AdweyaControllercs/Edit/5
        public ActionResult Edit(int id)
        {
            var tb = _context.aDweyas.Where(e => e.id_adweya == id).FirstOrDefault();

            return View(tb);
        }

        // POST: AdweyaControllercs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( ADweya aDweya)
        {


            _context.aDweyas.Update(aDweya);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));



        }

        // GET: AdweyaControllercs/Delete/5
       
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var tb = _context.aDweyas.Where(e => e.id_adweya == id).SingleOrDefault();
                _context.aDweyas.Remove(tb);
                _context.SaveChanges();

              return RedirectToAction(nameof(Index));
            }
              
            catch
            {
                return View();
            }
        }
    }
}
