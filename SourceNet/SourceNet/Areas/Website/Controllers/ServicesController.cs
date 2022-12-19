using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceNet.Areas.Website.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Parking()
        {
            return View();
        }

        public IActionResult SystemDevelopment()
        {
            return View();
        }
        public IActionResult AutomationSystem()
        {
            return View();
        }
        public IActionResult InternetService()
        {
            return View();
        }
        public IActionResult RevenueSystems()
        {
            return View();
        }
        public IActionResult EcommerceApplications()
        {
            return View();
        }
        public IActionResult PaymentSolutions()
        {
            return View();
        }

        public IActionResult SecuredSystems()
        {
            return View();
        }
    }
}
