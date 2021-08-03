using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuickKartCoreMVCApp.Models;
using QuickKartDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuickKartCoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QuickKartRepository _repObj;
        
        public HomeController(ILogger<HomeController> logger, QuickKartRepository repObj)
        {
            _repObj = repObj;
            _logger = logger;
        }

        //public string Index(string id)
        //{
        //    if (id == null)
        //    {
        //        return @"Hello...!!! My First MVC app";
        //    }
        //    return @"Id passed is " + id;
        //}

        public IActionResult CheckRole(IFormCollection frm)
        {
            string userId = frm["name"];
            string password = frm["pwd"];
            byte? roleId = _repObj.ValidateCredentials(userId, password);
            if (roleId == 1)
            {
                return RedirectToAction("AdminHome", "Admin");
            }
            else if (roleId == 2)
            {
                return RedirectToAction("CustomerHome", "Customer");
            }
            return View("Login");
        }



        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        public IActionResult Login()
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
