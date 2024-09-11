using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StokProjesi.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace MVC_StokProjesi.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori

        MVCDBSTOKEntities db = new MVCDBSTOKEntities();
        public ActionResult Index(int sayfa=1)
        {
            //var degerler = db.TBL_KATEGORILER.ToList();
            var degerler=db.TBL_KATEGORILER.ToList().ToPagedList(sayfa,4);
            return View(degerler);
        }

        [HttpGet] // sayfayi yukle sadece
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost] //sayfada degisiklik yapildiginda yap 
        public ActionResult YeniKategori(TBL_KATEGORILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.TBL_KATEGORILER.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult SIL(int id)
        {
            var kategori = db.TBL_KATEGORILER.Find(id);
            db.TBL_KATEGORILER.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.TBL_KATEGORILER.Find(id);
            return View("KategoriGetir",ktgr);
        }

        public ActionResult Guncelle(TBL_KATEGORILER p1)
        {
            var ktg = db.TBL_KATEGORILER.Find(p1.KATEGORIID);
            ktg.KATEGORIAD=p1.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}