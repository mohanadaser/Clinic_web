using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic.Models.myDB;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    public class ReportsController : Controller
    {

        private myDBcontext _context;
       

        public ReportsController( myDBcontext context)
        {
            _context = context;
           
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            return View();
        }
        // تقرير المصروفات

        public IActionResult reportmasrofat(DateTime dateto,DateTime datefrom)
        {
            var reptmasrof = _context.masrofats.Where(e => e.addtime_masrof.Date >= datefrom.Date && e.addtime_masrof.Date <= dateto.Date).ToList();
            ViewBag.dateto = dateto.ToLongDateString();
            ViewBag.datefrom = datefrom.ToLongDateString();
            ViewBag.total = _context.masrofats.Where(e => e.addtime_masrof >= datefrom && e.addtime_masrof <= dateto).Sum(e => e.amount);
            return View(reptmasrof);

        }

        public IActionResult reportiradat(DateTime dateto, DateTime datefrom)
        {

            var reptiradat = _context.iradats.Where(e => e.addtime_irad.Date >= datefrom.Date && e.addtime_irad.Date <= dateto.Date).ToList();
            ViewBag.dateto = dateto.ToLongDateString();
            ViewBag.datefrom = datefrom.ToLongDateString();
            ViewBag.totalirad = _context.iradats.Where(e => e.addtime_irad.Date >= datefrom.Date && e.addtime_irad.Date <= dateto.Date).Sum(e => e.amount);
            return View(reptiradat);

        }


        public IActionResult reportpatient(DateTime dateto, DateTime datefrom)
        {
            var reptpatient = _context.patients.Where(e => e.addtime.Date >= datefrom.Date && e.addtime.Date <= dateto.Date).ToList();
            ViewBag.dateto = dateto.ToLongDateString();
            ViewBag.datefrom = datefrom.ToLongDateString();
            ViewBag.totalamount = _context.patients.Where(e => e.addtime.Date >= datefrom.Date && e.addtime.Date <= dateto.Date).Sum(e => e.paied);
            return View(reptpatient);


        }

        public IActionResult reportadweya()
        {
            var reportadweya = _context.aDweyas.ToList();

            return View(reportadweya);
        }

        public IActionResult reportonline(DateTime dateto, DateTime datefrom)
        {

            var reportonline = _context.onlines.Where(e => e.date_online.Date >= datefrom.Date && e.date_online.Date <= dateto.Date).ToList();
            ViewBag.dateto = dateto.ToLongDateString();
            ViewBag.datefrom = datefrom.ToLongDateString();

            return View(reportonline);

        }


    }
}
