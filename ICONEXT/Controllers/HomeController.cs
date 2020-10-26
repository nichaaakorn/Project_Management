﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ICONEXT.Models;

namespace ICONEXT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult login()
        {
            return View();
        }

       

        public IActionResult AddManpower()
        {
            return View();
        }


        public IActionResult Holiday()
        {
            return View();
        }

       
        public IActionResult Leave()
        {
            return View();
        }

        public IActionResult AddLeave()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();
        }

        public IActionResult ViewProject()
        {
            return View();
        }

        public IActionResult Manpower()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }


        public IActionResult Organization()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
