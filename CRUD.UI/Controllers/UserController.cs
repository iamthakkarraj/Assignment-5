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
            return View(_UserService.GetUsers());
        }

        // GET: User/Details/5
        public ActionResult Details(int id) {
            return View(_UserService.GetUser(id));
        }

        // GET: User/Create
        public ActionResult Create() {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModel user) {
            try {
                if (_UserService.AddUser(user)) {
                    TempData["Success"] = "User Created Successfully !";
                    return RedirectToAction("Index");
                } else {
                    TempData["Erro"] = "Error Creating Users.";
                    return View();
                }                
            }
            catch {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id) {
            return View(_UserService.GetUser(id));
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(UserModel user) {
            try {
                if (_UserService.UpdateUser(user)) {
                    TempData["Success"] = "User Updated Successfully !";
                    return RedirectToAction("Index");
                } else {
                    TempData["Error"] = "Error Updating User.";
                    return View();
                }                
            }
            catch {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id) {
            if (_UserService.DeleteUser(id)) {
                TempData["Success"] = "User Deleted Successfully !";
            } else {
                TempData["Error"] = "Error Deleting User.";
            }
            return RedirectToAction("Index");
        }
        
    }

}