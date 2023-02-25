using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTaste.Controllers
{
    public class Anasayfa : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
