using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceNet.Areas.Website.Controllers
{
    public class TechnologyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
