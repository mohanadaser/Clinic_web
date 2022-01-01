using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    public class OnlineController : Controller
    {


        private myDBcontext _context;
        public OnlineController(myDBcontext context)
        {
            _context = context;

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: OnlineController
        public ActionResult Index()
        {

            var tb = _context.onlines.ToList();
            return View(tb);
        }

        // GET: OnlineController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OnlineController/Create
        public ActionResult Create(bool issuccess=false)
        {

            ViewBag.issuccess = issuccess;
            return View();
        }

        // POST: OnlineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Online online)
        {
            if (ModelState.IsValid)
            {
               
                _context.onlines.Add(online);
               
                _context.SaveChanges();

                return RedirectToAction("create", new {issuccess=true });
                 
            }

            return View();
        }

        // GET: OnlineController/Edit/5
        public ActionResult Edit(int id)
        {
            var tb = _context.onlines.Where(e => e.id_online == id).SingleOrDefault();
            return View(tb);
        }

        // POST: OnlineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Online online)
        {
            try
            {

                var tb = _context.onlines.Where(e => e.id_online == id).SingleOrDefault();

                tb.date_online = online.date_online;
                tb.adress_online = online.adress_online;
                tb.description = online.description;
                tb.name_online = online.name_online;
                tb.phone_online = online.phone_online;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OnlineController/Delete/5
      
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                var tb = _context.onlines.Where(e => e.id_online == id).SingleOrDefault();
                _context.onlines.Remove(tb);
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
