using ClassworkApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ClassworkApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View(new Login());
        }

        [HttpPost]
        public ActionResult Index(Login login,string ReturnUrl="")
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(login.Username, login.Password))
                {
                    ClassworkApplication.Models.User user=( ClassworkApplication.Models.User)Session["user"];
                    if(user.Status)
                    {
                        FormsAuthentication.SetAuthCookie(login.Username, false);
                        return RedirectToAction("Index","Admin/Dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Your account is not active yet");
                    }
                }
                else
                {
                    ModelState.AddModelError("","Invalid Usename/Password");
                }
            }
            else
            {
                ModelState.AddModelError("", "");
            }
            return View(new Login());
        }
    }
}