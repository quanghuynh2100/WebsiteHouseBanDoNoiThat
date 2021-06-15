using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteHouseBanDoNoiThat.Model;

namespace WebsiteHouseBanDoNoiThat.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        WebsiteHouseBanDoNoiThatDbContext db = new WebsiteHouseBanDoNoiThatDbContext();
        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            USER user = db.USERS.SingleOrDefault(x => x.UserName == username && x.PassWord == password && x.Allowed == 1);
            if (user != null)
            {
                Session["userid"] = user.UserId;
                Session["username"] = user.UserName;
                Session["avatar"] = user.Avatar;
                return RedirectToAction("Index");
            }
            ViewBag.error = "Sai tên đăng nhập hoặc mật khẩu!";
            return View();
        }
    }
}