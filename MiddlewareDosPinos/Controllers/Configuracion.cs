using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDosPinos.Controllers
{
    public class Configuracion : Controller
    {
        public IActionResult Configurar()
        {
            return View();
        }
        public IActionResult Configurars()
        {
            return View();
        }

    }
}
