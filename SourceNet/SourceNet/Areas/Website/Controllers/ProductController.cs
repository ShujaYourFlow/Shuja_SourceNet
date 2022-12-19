using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceNet.Areas.Website.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VeridocHr()
        {
            return View();
        }
        public IActionResult VeridocSupplyChain()
        {
            return View();
        }

        public IActionResult VeridocDocsign()
        {
            return View();
        }
        public IActionResult VeridocSmartLogin()
        {
            return View();
        }
        public IActionResult VeridocAnalytics()
        {
            return View();
        }
        public IActionResult VeridocDocuments()
        {
            return View();
        }

        public IActionResult VeridocLogbook()
        {
            return View();
        }
    }
}
