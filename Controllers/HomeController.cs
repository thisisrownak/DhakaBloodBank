using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MDRownakJahanTanjil_296627.Models;

namespace MDRownakJahanTanjil_296627.Controllers
{
    public class HomeController : Controller
    {
        MDRownakJahanTanjil_296627Entities db = new MDRownakJahanTanjil_296627Entities();
        public ActionResult Index()
        {
            var req = db.Requests.Where(r => r.Status == true).OrderByDescending(r => r.ReqID).Take(3);
            ViewBag.requests = req;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}