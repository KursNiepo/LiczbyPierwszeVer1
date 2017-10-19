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
            return View(number);
        }
    }
}