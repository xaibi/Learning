using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessObject.Model;
using FirtApp.Models;

namespace FirtApp.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/


        [HttpGet]
        public ActionResult AddUser()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            UserVM userVM = new UserVM();
           String message  =  userVM.Build(user);
           TempData["message"] = message;

            return View();
        }
	}
}