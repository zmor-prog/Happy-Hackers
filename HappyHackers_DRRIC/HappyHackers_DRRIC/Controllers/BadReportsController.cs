using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyHackers_DRRIC.Models;

namespace HappyHackers_DRRIC.Controllers
{
    public class BadReportsController : Controller
    {
        private BadReportsContext context { get; set; }

        public BadReportsController(BadReportsContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Cryptocurrencys = context.Cryptocurrencys.OrderBy(m => m.Code).ToList();
            ViewBag.Categorys = context.Categorys.OrderBy(m => m.Crime).ToList();
            ViewBag.PostingLicensees = context.PostingLicensees.OrderBy(m => m.LicenseeName).ToList();
            return View("Edit", new BadReports());
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Cryptocurrencys = context.Cryptocurrencys.OrderBy(m => m.Code).ToList();
            ViewBag.Categorys = context.Categorys.OrderBy(m => m.Crime).ToList();
            ViewBag.PostingLicensees = context.PostingLicensees.OrderBy(m => m.LicenseeName).ToList();
            var reports = context.BadReport.Find(id);
            return View(reports);
        }

        [HttpPost]
        public IActionResult Edit(BadReports reports)
        {
            if (ModelState.IsValid)
            {
                // If the UID is null, set it to abrabcabra+ a random number. Example: uid=abracabraStringNameExample+'12313132'
                if (reports.uid == "" || reports.uid == null)
                {

                    Random r = new Random();
                    int num = r.Next();
                    //StringNameExample
                    reports.uid = "106820062" + num.ToString();
                    context.BadReport.Add(reports);
                }
                else
                    context.BadReport.Update(reports);

                context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.Action = reports.uid == "" ? "Add" : "Edit";
                ViewBag.Cryptocurrencys = context.Cryptocurrencys.OrderBy(m => m.Code).ToList();
                ViewBag.Categorys = context.Categorys.OrderBy(m => m.Crime).ToList();
                ViewBag.PostingLicensees = context.PostingLicensees.OrderBy(m => m.LicenseeName).ToList();
                return View(reports);
            }
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            var reports = context.BadReport.Find(id);
            return View(reports);
        }

        [HttpPost]
        public IActionResult Delete(BadReports reports)
        {
            context.BadReport.Remove(reports);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
            
        }
    }
}
