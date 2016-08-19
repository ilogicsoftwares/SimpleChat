using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleChat.Models;

namespace SimpleChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Chat(Chat chat)
        {
            if (ModelState.IsValid)
            {
                ViewBag.canal = chat.canal;
                ViewBag.user = chat.user;
                return View();
            }else
            {
                return View("Index");
            }
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