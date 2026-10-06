using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B5.Controllers
{
    public class Amazon : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
