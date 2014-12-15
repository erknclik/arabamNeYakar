using ArabamNeYakar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArabamNeYakar.Controllers
{
    public class LogInController : Controller
    {
        //
        // GET: /LogIn/

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(User user)
        {
            ArabamNeYakarContext db = new ArabamNeYakarContext();

            var sonuc = db.users.Where(q => q.userName == user.userName && q.password == user.password);
            if (sonuc.Count()>0)
            {
                Session["KullaniciBilgileri"] = (User)sonuc.SingleOrDefault();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

    }
}
