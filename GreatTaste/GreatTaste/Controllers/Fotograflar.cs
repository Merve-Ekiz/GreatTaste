using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTaste.Controllers
{
    public class Fotograflar : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OzelMenu()
        {
            return View();
        }
        public IActionResult DiyetYemek()
        {
            return View();
        }
    }
}
