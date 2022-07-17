using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logister.Models;
using System.Web.Security;


namespace logistic_manager.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(user objchk)
        {
            if (ModelState.IsValid)
            {
                using (Model2 db = new Model2())
                {
                    var obj = db.users.Where(a => a.Username.Equals(objchk.Username) && a.Password.Equals(objchk.Password)).FirstOrDefault();

                    if (obj != null)
                    {
                        Session["Username"] = obj.Username.ToString();
                        return RedirectToAction("Index", "imports");
                    }
                    else
                    {
                        ModelState.AddModelError("", "username and password is incorrect");
                    }
                }
            }

            return View(objchk);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}