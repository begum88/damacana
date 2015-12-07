using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using damacana.DAL;
using damacana.DAL.Models;
using damacana.Models;

namespace damacana.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                DamacanaEntities _db = new DamacanaEntities();
                User user = _db.User.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);

                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    return Redirect(returnUrl ?? "/");
                }

                ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış");
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                DamacanaEntities _db = new DamacanaEntities();
                User user = _db.User.FirstOrDefault(x => x.UserName == model.UserName);

                if (user != null)
                {
                    ModelState.AddModelError("", "Bu kullanıcı adı alınmıştır");
                }
                else
                {
                    User u = new User()
                    {
                        UserName = model.UserName,
                        Name = model.Name,
                        Surname = model.Surname,
                        Password = model.Password
                    };
                    _db.User.Add(u);
                    _db.SaveChanges();

                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect("/");
                }
            }
            return View(model);
        }

        public ActionResult Logout() 
        {
             FormsAuthentication.SignOut();
            return Redirect("/");
        }
	}
}