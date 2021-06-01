using Microsoft.AspNetCore.Mvc;
using MiddlewareDosPinos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDosPinos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

     

        public IActionResult Olvido_Contraseña()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult Crear_Cuenta()
        {
            return View();
        }

    }
}
