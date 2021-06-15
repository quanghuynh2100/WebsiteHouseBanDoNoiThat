using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteHouseBanDoNoiThat.Model;

namespace WebsiteHouseBanDoNoiThat.Controllers
{
    public class HomeController : Controller
    {
        WebsiteHouseBanDoNoiThatDbContext db = new WebsiteHouseBanDoNoiThatDbContext();
        public ActionResult Index()
        {
            ViewBag.BeTrai = db.SanPhams.Where(x => x.MaDoiTuong == "MDT001").Take(8).ToList();
            ViewBag.BeGai = db.SanPhams.Where(x => x.MaDoiTuong == "MDT002").Take(8).ToList();
            ViewBag.TreSoSinh = db.SanPhams.Where(x => x.MaDoiTuong == "MDT003").Take(8).ToList();
            ViewBag.PhuKien = db.SanPhams.Where(x => x.MaTheLoai == "MTL008").Take(8).ToList();
            ViewBag.SanPhamMoi = db.SanPhams.OrderByDescending(x => x.NgayCapNhat).Take(4).ToList();
            ViewBag.SanPhamBanChay = db.SanPhams.OrderByDescending(x => x.SoLuongBan).Take(4).ToList();
            return View();
        }

        public ActionResult BeTrai()
        {
            ViewBag.BeTrai = db.SanPhams.Where(x => x.MaDoiTuong == "MDT001").Take(10000).ToList();

            return View();
        }

        public ActionResult BeGai()
        {
            ViewBag.BeGai = db.SanPhams.Where(x => x.MaDoiTuong == "MDT002").Take(10000).ToList();

            return View();
        }
        public ActionResult TreSoSinh()
        {
            ViewBag.TreSoSinh = db.SanPhams.Where(x => x.MaDoiTuong == "MDT003").Take(10000).ToList();

            return View();
        }
        public ActionResult PhuKien()
        {
            ViewBag.PhuKien = db.SanPhams.Where(x => x.MaTheLoai == "MTL008").Take(10000).ToList();

            return View();
        }
        public ActionResult Details(string id)
        {
            //Tìm sách có mã sách = id
            SanPham sp = db.SanPhams.SingleOrDefault(x => x.MaSanPham == id);
            //Nếu không tìm thấy
            if (sp == null)
            {
                return HttpNotFound();
            }
            return View(sp);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}