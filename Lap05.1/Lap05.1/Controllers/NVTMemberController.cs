
using Lap05._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lap05._1.Controllers
{
    public class NVTMemberController : Controller
    {
        // GET: NVTMember
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateOne()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOne(NVTMember m)
        {
            return View("Details", m);
        }
        public ActionResult CreateTwo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTwo(NVTMember m)
        {
            if (m.Id == null)
            {
                ViewBag.error = "Hãy nhập mã số";
                return View();
            }
            if (m.Usename == null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.Fullname == null)
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.Age == null)
            {
                ViewBag.error = "Hãy nhập tuổi ";
                return View();
            }
            if (m.Email == null)
            {
                ViewBag.error = "Hãy nhập Email";
                return View();
            }
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if(
            !System.Text.RegularExpressions.Regex.IsMatch(m.Email,regexPattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";
                return View();
            }
            return View("Details0", m);
        }
        public ActionResult CreateThree()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateThree(NVTMember m)
        {
            if (ModelState.IsValid)
                return View("Details", m);
            else
                return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}