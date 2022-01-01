using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Clinic.Models;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Clinic.Controllers
{
    public class HomeController : Controller
    {

        private myDBcontext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, myDBcontext context)
        {
            _context = context;
            _logger = logger;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public IActionResult Index()
        {

            return View();
        }
      

        [HttpGet]
        public IActionResult login() 
        {

            return View();
        }

        [HttpPost]
        public IActionResult login(Users users)
        {

            var tbusers = _context.users.Where(c => c.Username == users.Username && c.Password == users.Password).FirstOrDefault();
            if (users.Username == null && users.Password == null)
            {
                ViewBag.message = "";
                return View();

            }

            else if (tbusers == null)
            {
                ViewBag.message = "يوجد خطا فى اسم المستخدم او كلمة المرور او لم يتم تسجيل الاشتراك فى الموقع";

                return View();
            }


            // عمل session للمستخدمين
            else
            {
                HttpContext.Session.SetString("username", tbusers.Username);
                HttpContext.Session.SetString("userid", tbusers.id_user.ToString());
             


                return RedirectToAction("admin", "Home");
            }
           
        }

        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index", "Home");
        }



        public IActionResult about_us()

        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult admin()
        {


            ViewBag.total = _context.patients.Where(e => e.addtime.Date == DateTime.Today).Sum(x => x.paied);
            ViewBag.count = _context.patients.Where(e => e.addtime.Date == DateTime.Today).Count();
            ViewBag.totaldayirad = _context.iradats.Where(e => e.addtime_irad.Date == DateTime.Today).Sum(x => x.amount);
            ViewBag.totalday = _context.masrofats.Where(e => e.addtime_masrof.Date == DateTime.Today).Sum(x => x.amount);
            ViewBag.online = _context.onlines.Where(e => e.date_online.Date == DateTime.Today).Count();
            ViewBag.onlinecount = _context.onlines.Count();
            ViewBag.adweyacount = _context.aDweyas.Count();
            ViewBag.patientcoubt = _context.patients.Count();
            ViewBag.profit = ViewBag.total + ViewBag.totaldayirad - ViewBag.totalday;

            return View();
        }
        [HttpGet]
        public IActionResult Iradatamount()
        {

            var tb = _context.iradats.ToList();

            return new JsonResult(tb);

        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
