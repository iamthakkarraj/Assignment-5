using CRUD.BLL.Interface;
using CRUD.BLL.Service;
using CRUD.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.UI;

namespace CRUD.UI.Controllers {
    
    [AuthenticationAttribute]
    public class UserController : Controller {

        private readonly IUserService _UserService;

        public UserController() {
            _UserService = new UserService();
        }

        // GET: User
        public ActionResult Index() {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: User/Create
        public ActionResult Create() {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModel user) {
            try {
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(UserModel user) {
            try {                
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }
        
    }

}