using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickKartCoreMVCApp.Controllers
{
    [Route("Administrator")]
    public class AdminController : Controller
    {
        public IActionResult AdminHome()
        {
            return View();
        }

        [Route("Product")]
        public string AddProduct()
        {
            return @"This is Admin Home Page";
        }
    }
}
