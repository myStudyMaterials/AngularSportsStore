using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SportsStore.UI.Helpers;
using SportsStore.ViewModals;

namespace SportsStore.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetProducts()
        {
            return Json(ProductDetailsHelper.GetProducts());
        }
    }
}