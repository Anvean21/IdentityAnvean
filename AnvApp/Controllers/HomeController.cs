using AnvApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnvApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //IList<string> roles = new List<string> { "Роль не определена" };
            //ApplicationUserManager userManager = HttpContext.GetOwinContext()
            //                                        .GetUserManager<ApplicationUserManager>();
            //ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
            //if (user != null)
            //    roles = userManager.GetRoles(user.Id);
            //return View(roles);
            //var db = new Db();
            //db.Database.Initialize(true);
            return View();
        }
    }
}