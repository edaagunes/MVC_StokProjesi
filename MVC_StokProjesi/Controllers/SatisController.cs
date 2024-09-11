using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StokProjesi.Models.Entity;

namespace MVC_StokProjesi.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis

        MVCDBSTOKEntities db = new MVCDBSTOKEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(TBL_SATISLAR p)
        {
            db.TBL_SATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}