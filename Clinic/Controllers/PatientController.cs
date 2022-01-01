using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Controllers
{
    public class PatientController : Controller
    {

        private myDBcontext _context;
        public PatientController(myDBcontext context)
        {

          
            _context = context;

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: PatientController

        public IActionResult Search()
        {
            var tb = _context.patients.ToList();

            return View(tb);
        }
        public  ActionResult Index() 
        {
            var tb = _context.patients.Where(e => e.addtime.Date == DateTime.Today).ToList();
            ViewBag.total = _context.patients.Where(e => e.addtime.Date == DateTime.Today).Sum(x => x.paied);
            ViewBag.stsh= _context.patients.Where(e => e.addtime.Date == DateTime.Today&&e.type_kashf=="استشاره").Sum(x => x.paied);
            ViewBag.eda= _context.patients.Where(e => e.addtime.Date == DateTime.Today && e.type_kashf == "اعاده").Sum(x => x.paied);
            return View(tb);
            

        }
         
      
        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            var tb = _context.patients.Where(e => e.idpatiend == id).SingleOrDefault();
            return View(tb);
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(patient patient)
        {
            if (ModelState.IsValid)
            {
                //patient.addtime = DateTime.Now;
                   
                _context.patients.Add(patient);   
                _context.SaveChanges();
              
              
                return RedirectToAction(nameof(Index));
            }
           

            return View();
            
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            var tb = _context.patients.Where(e => e.idpatiend == id).SingleOrDefault();
            return View(tb);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, patient patient)
        {
            try
            {
                var tb = _context.patients.Where(e => e.idpatiend == id).SingleOrDefault();
                tb.name_patient = patient.name_patient;
                tb.code = patient.code;
                tb.phone_patient = patient.phone_patient;
                tb.age = patient.age;
                tb.phone_patient = patient.phone_patient;
                tb.type_kashf = patient.type_kashf;
                tb.notes = patient.notes;
                tb.paied = patient.paied;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
      
        // POST: PatientController/Delete/5
      
        public ActionResult Delete(int id)
        {
            try
            {
                var tb = _context.patients.Where(e => e.idpatiend == id).SingleOrDefault();

                _context.patients.Remove(tb);
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
