using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HappyHackers_DRRIC.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyHackers_DRRIC.Controllers
{
    public class HomeController : Controller
    {
        private BadReportsContext context { get; set; }

        public HomeController(BadReportsContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            //var reports = context.BadReport.Include(m => m.Cryptocurrency).OrderBy(m => m.Cryptocurrency).ToList();
            //    reports = context.BadReport.Include(m => m.Category).OrderBy(m => m.Category).ToList();
            //    reports = context.BadReport.Include(m => m.PostingLicensee).OrderBy(m => m.PostingLicensee).ToList();
            var reports = context.BadReport.Include(m => m.Category).Include(m => m.Cryptocurrency).Include(m => m.PostingLicensee).ToList();
            return View(reports);
        }
     
    }
}
