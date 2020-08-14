using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstProject.Models;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            //ternary operator -- it has three parts, 
            //a predicate, a true, and a false
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);
        }
            //public ViewResult Index()
            //{
            //    return View("MyView");
            //}


            //public string Index()
            //{
            //    return "Hello World";
            //}
            //private readonly ILogger<HomeController> _logger;//field

            //public HomeController(ILogger<HomeController> logger)//constructor
            //{
            //    _logger = logger;
            //}

            //public IActionResult Index()
            //{
            //    return View();
            //}

            //public IActionResult Privacy()
            //{
            //    return View();
            //}

            //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            //public IActionResult Error()
            //{
            //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            //}
        }
}
