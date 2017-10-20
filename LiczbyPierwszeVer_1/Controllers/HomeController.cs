using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiczbyPierwszeVer_1.Models;

namespace LiczbyPierwszeVer_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private MyNumber myNumber;
        public ActionResult Index()
        {
            myNumber = new MyNumber();
            return View(myNumber);
        }
        //POST: Home
        [HttpPost]
        public ActionResult Index(MyNumber number) {
            List<int> list = null;
            if (ModelState.IsValid) {
                ViewBag.OK = true;
                int limit = number.NumCols * number.NumRows;
                PrimaryNumbers pn = new PrimaryNumbers();
                list = pn.GetAllPrimary(limit);
                ViewBag.List = list;
            }
            else {
                ViewBag.OK = false;
                ViewBag.List = null;
            }
            return View();
        }
    }
}