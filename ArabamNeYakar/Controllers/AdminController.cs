using ArabamNeYakar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArabamNeYakar.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KullaniciTanimlama()
        {
            ArabamNeYakarContext db = new ArabamNeYakarContext();
            ViewBag.Roles = db.roles.ToList();

            return View();
        }
        [HttpPost]
        public ActionResult KullaniciTanimlama(User user)
        {
            ArabamNeYakarContext db = new ArabamNeYakarContext();

            user.updateDate = DateTime.Now;
            user.updateUserName = ((User)Session["KullaniciBilgileri"]).userName;
            user.status = 1;
            user.passive = true;
            db.users.Add(user);
            db.SaveChanges();

            return RedirectToAction("KullaniciTanimlama","Admin");
        }
    }
}
