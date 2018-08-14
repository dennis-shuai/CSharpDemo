using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string Name="world",int numtimes=1)
        {
         
            //return "Welcome " + HttpUtility.HtmlEncode(Name);
            ViewBag.Message = "Hello " + Name;
            ViewBag.NumTimes = numtimes;
            return View();
        }
    }
}