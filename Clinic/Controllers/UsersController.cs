using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
  
    public class UsersController : Controller
    {


        private myDBcontext _context;
        public UsersController(myDBcontext context)
        {
            _context = context;

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: UsersController
        public ActionResult Index()
        {

            ViewBag.usr = _context.users.ToList();

            return View();
            
        }

       
        // GET: UsersController/Create
        public ActionResult Create()
        {

            return View();
          
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Users users)
        {

            if (ModelState.IsValid)
            {
                _context.users.Add(users);
                _context.SaveChanges();

            }

            return RedirectToAction(nameof(Index));
        }

        // GET: UsersController/Edit/5
        [HttpGet]

        public IActionResult Find(int id)

        {

            var users = _context.users.Find(id);

            return new JsonResult(users);
        }


        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id,Users users)
        {

            var tb = _context.users.Find(id);
            tb.Username = users.Username;
            tb.Password = users.Password;
            _context.SaveChanges();


                return RedirectToAction(nameof(Index));


           
        }

        // GET: UsersController/Delete/5
       
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var tb = _context.users.Where(e => e.id_user == id).SingleOrDefault();
            _context.users.Remove(tb);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
