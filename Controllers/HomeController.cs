using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentApp.Domain;
using StudentApp.Models;
using StudentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
  
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        
        }

        public IActionResult Index()
        {
            try
            {
                
                return View();
            }
            catch (Exception ex)
            {
              
                return View("Error", new ErrorViewModel() { ExceptionMessage = ex.Message});
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { ExceptionMessage = "Error!" });
        }
    }
}
