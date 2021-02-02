using Sample.BingMaps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.BingMaps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _db = new ApplicationDBContext();

        public ActionResult Index()
        {
            return View(_db.Houses.ToList()); ;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                var hs = new Houses
                {
                    LabelHouse = collection["LabelHouse"].ToString(),
                    TypeHouse = Convert.ToInt32(collection["TypeHouse"].ToString()),
                    Address = collection["Address"].ToString()

                };
                _db.Houses.Add(hs);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(collection);
        }
    }
}