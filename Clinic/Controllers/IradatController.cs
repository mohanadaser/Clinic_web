using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    public class IradatController : Controller
    {

            private myDBcontext _context;
            public IradatController(myDBcontext context)
            {

                _context = context;

            }

            protected override void Dispose(bool disposing)
            {
                _context.Dispose();
            }
            // GET: IradatController
            public ActionResult Index()
        {

            ViewBag.iradat = _context.iradats.Where(e => e.addtime_irad.Date == DateTime.Today).ToList();
            ViewBag.totaldayirad = _context.iradats.Where(e => e.addtime_irad.Date == DateTime.Today).Sum(x => x.amount);
            return View();
            
        }

        // GET: IradatController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IradatController/Create
       

        // POST: IradatController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IRadat iradat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    iradat.addtime_irad = DateTime.Now;
                    _context.iradats.Add(iradat);
                    _context.SaveChanges();


                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IradatController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IradatController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IradatController/Delete/5
       
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                var tb = _context.iradats.Where(e => e.id_irad == id).SingleOrDefault();
                _context.iradats.Remove(tb);
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
