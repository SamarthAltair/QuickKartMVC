using Microsoft.AspNetCore.Mvc;
using QuickKartDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickKartCoreMVCApp.Controllers
{
    [Route("Administrator")]
    public class AdminController : Controller
    {
        private readonly QuickKartRepository _repObj;
        public AdminController(QuickKartRepository repObj)
        {
            _repObj = repObj;
        }

        public IActionResult AdminHome()
        {
            List<string> lstProducts = new List<string>();
            lstProducts.Add("See and Say");
            lstProducts.Add("Wall Stickers");
            lstProducts.Add("Curtains");
            ViewBag.TopProducts = lstProducts;
            return View();
        }
    }
}
