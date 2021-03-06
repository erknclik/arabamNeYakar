﻿using ArabamNeYakar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArabamNeYakar.Controllers
{
    public class LogOnController : Controller
    {
        //
        // GET: /LogOn/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {

            ArabamNeYakarContext db = new ArabamNeYakarContext();
            if (ModelState.IsValid)
            {
                user.passive = true;
                user.status = 1;
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

    }
}
