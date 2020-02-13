﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MuroAgil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			return RedirectToAction("Index", "UsuarioMuro");
        }
    }
}