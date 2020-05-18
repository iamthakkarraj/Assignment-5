using CRUD.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.BLL.Service;
using CRUD.BLL.Interface;

namespace CRUD.UI.Controllers {

    public class AuthenticationController : Controller {

        private readonly IAuthenticationService _AuthenticationService;

        public AuthenticationController() {
            _AuthenticationService = new AuthenticationService();
        }

        // GET: Login
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login) {
            if (ModelState.IsValid) {
                if (_AuthenticationService.VerifyUser(login)) {
                    Session["IsAuthenticated"] = true;
                    return RedirectToAction("Index", "User");
                } else {
                    return View();
                };
            } else {
                return View();
            }
        }

        public ActionResult Logout() {
            if(Session["IsAuthenticated"] != null) {
                Session["IsAuthenticated"] = false;
            }
            return RedirectToAction("Login");
        }

    }
}