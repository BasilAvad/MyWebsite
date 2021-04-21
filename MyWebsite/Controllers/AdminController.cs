using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Models.Sınıflar;
namespace MyWebsite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.RecentProjectss.ToList();
            
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(RecentProject recentProject)
        {
            c.RecentProjectss.Add(recentProject);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var blog = c.RecentProjectss.Find(id);
            c.RecentProjectss.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var blog1 = c.RecentProjectss.Find(id);
            return View("BlogGetir",blog1);
        }
        public ActionResult BlogGuncelle(RecentProject recentProject)
        {
            var blog2 = c.RecentProjectss.Find(recentProject.Id);
            blog2.Aciklama = recentProject.Aciklama;
            blog2.Aciklama2 = recentProject.Aciklama2;
            blog2.Aciklama3 = recentProject.Aciklama3;
            blog2.Aciklama4 = recentProject.Aciklama4;
            blog2.Aciklama5 = recentProject.Aciklama5;
            blog2.Baslik = recentProject.Baslik;
            blog2.RecentProjectsImage = recentProject.RecentProjectsImage;
            blog2.RecentProjectsImage2 = recentProject.RecentProjectsImage2;
            blog2.RecentProjectsImage3 = recentProject.RecentProjectsImage3;
            blog2.RecentProjectsImage4 = recentProject.RecentProjectsImage4;
            blog2.RecentProjectsImage5 = recentProject.RecentProjectsImage5;
            blog2.Tarih = recentProject.Tarih;
            blog2.Kaynaklar = recentProject.Kaynaklar;
            blog2.Kaynaklar2 = recentProject.Kaynaklar2;
            blog2.Kaynaklar3 = recentProject.Kaynaklar3;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        /// 
        // <---- Comments----->
        public ActionResult YorumlarListesi()
        {
            var yorumlar1 = c.Yorumlars.ToList();
            return View(yorumlar1);
        }
        public ActionResult YorumSil(int id)
        {
            var blog = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("YorumlarListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yoru = c.Yorumlars.Find(id);
            return View("YorumGetir", yoru);
        }
        public ActionResult YorumGuncelle(Yorumlar _yorumlar)
        {
            var yrm = c.Yorumlars.Find(_yorumlar.Id);
            yrm.KullaniciAdi = _yorumlar.KullaniciAdi;
            yrm.Mail = _yorumlar.Mail;
            yrm.Yorum = _yorumlar.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumlarListesi");
        }
        // <---- Comments----->
        /// <summary>
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        //<----BOOKS----->
        public ActionResult BookListesi()
        {
            var book = c.Books.ToList();
            return View(book);
        }
        [HttpGet]
        public ActionResult YeniBook()
        {
            var deger = c.Books.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult YeniBook(Book book)
        {
            c.Books.Add(book);
            c.SaveChanges();
            return RedirectToAction("BookListesi");
        }
       
        public ActionResult BookSil(int id)
        {
            var blog = c.Books.Find(id);
            c.Books.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("BookListesi");
        }

        public ActionResult BookGetir(int id)
        {
            var bo = c.Books.Find(id);
            return View("BookGetir", bo);
        }
        public ActionResult BookgGuncelle(Book _book)
        {
            var bk = c.Books.Find(_book.Id);
            bk.Baslik = _book.Baslik;
            bk.Aciklama = _book.Aciklama;
            bk.BookImage = _book.BookImage;
            
            c.SaveChanges();
            return RedirectToAction("BookListesi");
        }
        //<----BOOKS'S----->
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
         //<----About'S----->
        public ActionResult AboutMeListesi()
        {
            var about = c.AboutMes.ToList();
            return View(about);
        }

        [HttpGet]
        public ActionResult YeniAbout()
        {
            var deger = c.AboutMes.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult YeniAbout(AboutMe _aboutMe)
        {
            c.AboutMes.Add(_aboutMe);
            c.SaveChanges();
            return RedirectToAction("AboutMeListesi");
        }
        public ActionResult AboutMeSil(int id)
        {
            var about3 = c.AboutMes.Find(id);
            c.AboutMes.Remove(about3);
            c.SaveChanges();
            return RedirectToAction("AboutMeListesi");
        }

        public ActionResult AboutMeGetir(int id)
        {
            var bou = c.AboutMes.Find(id);
            return View("AboutMeGetir", bou);
        }
        public ActionResult AboutMeGuncelle(AboutMe _boutMe)
        {
            var bme = c.AboutMes.Find(_boutMe.Id);
            bme.FotoUrl = _boutMe.FotoUrl;
            bme.Aciklama = _boutMe.Aciklama;
           
            c.SaveChanges();
            return RedirectToAction("AboutMeListesi");
        }
        //<----About'S----->
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            var contact = c.Contacts.ToList();
            return View(contact);
        }
        public ActionResult ContactSil(int id)
        {
            var con = c.Contacts.Find(id);
            c.Contacts.Remove(con);
            c.SaveChanges();
            return RedirectToAction("Contact");
        }
    }
}