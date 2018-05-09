using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Manager;

namespace Electronica.MVC.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult AddTopic()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTopic(TopicDTO topicDTO)
        {
            TopicManager topicManager = new TopicManager();
            topicManager.InsertTopic(topicDTO);
            return View();
        }

    }
}