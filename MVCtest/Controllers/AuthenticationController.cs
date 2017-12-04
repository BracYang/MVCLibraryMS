using MVCtest.Models;
using MVCtest.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCtest.Controllers
{
    public class AuthenticationController : Controller
    {

        BookService _service = new BookService();
        // GET: Authentication
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(UserLogin u)
        {
            if (ModelState.IsValid)
            {
                if (_service.IsValidUser(u))
                {
                    FormsAuthentication.SetAuthCookie(u.UserName, false);
                    return RedirectToAction("Index", "Book");
                }
                ModelState.AddModelError("Credential", "YOU ARE NOT OUR BRO");
            }
            return View("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}