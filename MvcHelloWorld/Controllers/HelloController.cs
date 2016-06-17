using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHelloWorld.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        public ActionResult Index()
        {
            return View();  //输出默认视图
            //return View("AspxView");  //以 ASPX 为语法的视图，对应的视图文件为"AspxView.aspx"
            //return View("IndexRazor"); //输出本控制器中的指定视图
            //return View("~/Views/Home/About.cshtml"); //输出其他控制器中的指定视图
        }

        public ActionResult Welcome(string name, int times = 1)
        {
            ViewBag.Message = "你好，" + name + "！";
            ViewBag.Times = times;
            return View();
        }
    }
}
