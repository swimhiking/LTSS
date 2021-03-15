using LTSS_Model.ViewModels;
using LTSS_Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LTSS_DataAccess.Repository.IRepository;

namespace LTSS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptionRepository _option;
        
        public HomeController(ILogger<HomeController> logger,               
                IOptionRepository option)
        {
            _logger = logger;            
            _option = option;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Calculation()
        {           
            return View();
        }

        public IActionResult Tab1()
        {
            var optionList = _option.GetAll();
            return PartialView("_TabPartial1", optionList);
        }

        public IActionResult Tab2()
        {
            return PartialView("_TabPartial2");
        }


        public IActionResult Tab3()
        {
            return PartialView("_TabPartial3");
        }

        public IActionResult Privacy()
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
