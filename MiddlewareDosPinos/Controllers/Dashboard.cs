﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDosPinos.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Panel_Dashboard()
        {
            return View();
        }
    }
}
