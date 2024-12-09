using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucTap2.Models;

namespace ThucTap2.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public JsonResult TestConnection(string server, string database, string username, string password)
        {
            try
            {
                string connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
                using (var context = new AppDbContext(connectionString))
                {
                    if (context.Database.Exists())
                    {
                        return Json(new { success = true, message = "Kết nối thành công!" });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Cơ sở dữ liệu không tồn tại." });
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


        public ActionResult Index()
        {
            return View();
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
        public ActionResult SVTT_CauHinh()
        {
            ViewBag.Message = "Your CapNhat page.";
            return View();
        }
    }
}