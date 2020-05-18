using CRUD.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.BLL.Service;
using CRUD.BLL.Interface;

namespace CRUD.UI.Controllers {

    public class LoginController : Controller {

        private readonly IAuthenticationService _AuthenticationService;

        public LoginController() {
            _AuthenticationService = new AuthenticationService();
        }

        // GET: Login
        public ActionResult Index() {
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
    }
}