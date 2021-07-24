using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApl.Models;
using System.Web.Security;

namespace MvcApl.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(AuthModel model)
        {
            if (model.Id == "test" && model.Password == "password")
            {
                FormsAuthentication.SetAuthCookie(model.Id, true);
                return RedirectToAction("Index", "Home");
            } 
            else
            {
                //ユーザ認証 失敗
                this.ModelState.AddModelError(string.Empty, "指定されたユーザ名またはパスワードが正しくありません");
                return this.View(model);
            }
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Auth", "Index");
        }
    }
}