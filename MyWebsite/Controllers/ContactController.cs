using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Models.Sınıflar;
namespace MyWebsite.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        public ActionResult Index()
        {
            var contact = c.Contacts.ToList();
            return View(contact);
        }
        [HttpGet]
        public ActionResult ContactYap()
        {
           
            return PartialView();
        }

        [HttpPost]
        public ActionResult ContactYap(Contact _contact)
        {
            c.Contacts.Add(_contact);
            c.SaveChanges();
            return PartialView();
        }
    }
}