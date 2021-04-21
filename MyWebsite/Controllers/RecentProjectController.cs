using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Models.Sınıflar;
namespace MyWebsite.Controllers
{
    public class RecentProjectController : Controller
    {
        // GET: RecentProject
        Context c = new Context(); 
        RecentProjectYorum RPy = new RecentProjectYorum();
        public ActionResult Index()
        {
            //var bloglar = c.RecentProjectss.ToList();
            RPy.Deger1 = c.RecentProjectss.ToList();
            RPy.Deger3 = c.RecentProjectss.OrderByDescending(x=>x.Id).Take(15).ToList();
            return View(RPy);
        }
       
        public ActionResult BlogDetay(int id)
        {

            //var blogbul = c.RecentProjectss.Where(x => x.Id == id).ToList();
            RPy.Deger1 = c.RecentProjectss.Where(x => x.Id == id).ToList();
            RPy.Deger2 = c.Yorumlars.Where(x => x.RecentProjectid == id).ToList();
            RPy.Deger3 = c.RecentProjectss.OrderByDescending(x => x.Id).Take(15).ToList();
            return View(RPy);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
            
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorumlaa)
        {
            c.Yorumlars.Add(yorumlaa);
            c.SaveChanges();
            return PartialView();
        }
        
    }
}