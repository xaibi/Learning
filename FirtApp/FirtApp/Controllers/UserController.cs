using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessObject.Model;

namespace FirtApp.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult AddUser(User user)
        {
            return View();
        }
	}
}