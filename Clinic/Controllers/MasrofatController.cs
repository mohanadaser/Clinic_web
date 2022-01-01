using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    public class MasrofatController : Controller
    {

        private myDBcontext _context;
        public MasrofatController(myDBcontext context)
        {
            _context = context;

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: MasrofatController
        public ActionResult Index()
        {
            ViewBag.masrofat = _context.masrofats.Where(e => e.addtime_masrof.Date == DateTime.Today).ToList();
            ViewBag.totalday = _context.masrofats.Where(e => e.addtime_masrof.Date == DateTime.Today).Sum(x => x.amount);
            return View();
        }

        // GET: MasrofatController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MasrofatController/Create
       

        // POST: MasrofatController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Masrofat masrofat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    masrofat.addtime_masrof = DateTime.Now;
                    _context.masrofats.Add(masrofat);
                _context.SaveChanges();

                }
               return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasrofatController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MasrofatController/Edit/5
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

        // GET: MasrofatController/Delete/5
       
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                var tb = _context.masrofats.Where(e => e.id_masrof == id).SingleOrDefault();
                _context.masrofats.Remove(tb);
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
