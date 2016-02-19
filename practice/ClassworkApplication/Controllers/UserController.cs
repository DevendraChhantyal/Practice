using ClassworkApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassworkApplication.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository = new UserRepository();
        // GET: User
        public ActionResult Index()
        {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            result.Data = _userRepository.GetAll();
            return result;
            
        }
    }
}