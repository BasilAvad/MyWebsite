using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Models.Sınıflar;
namespace MyWebsite.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.RecentProjectss.OrderByDescending(x => x.Id).Take(10).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult PartialView1()
        {
            var degerler = c.RecentProjectss.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(degerler);
        } 
        public PartialViewResult PartialView2()
        {
            var degerler2 = c.RecentProjectss.Where(x => x.Id==1).ToList();
            return PartialView(degerler2);
        } 
        public PartialViewResult PartialView3()
        {
            var degerler3 = c.RecentProjectss.Take(10).ToList();
            return PartialView(degerler3);
        }
        public PartialViewResult PartialView4()
        {
            var degerler4 = c.Books.Take(3).ToList();
            return PartialView(degerler4);
        }
        public PartialViewResult PartialView5()
        {
            var degerler5 = c.Books.OrderByDescending(x=>x.Id).Take(3).ToList();
            return PartialView(degerler5);
        }
    }
}