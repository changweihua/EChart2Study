using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.ComponentModel;
using Genernal.UI.Controllers;
using Genernal.UI.Models;

namespace HospitalReport.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "页面导航";
            ViewBag.Title = "HospitalReport";
            var controllers = Assembly.GetExecutingAssembly().GetTypes().Where(_ => _.Name.EndsWith("Controller") && _.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).Count() > 0)
                .Select(_ => new Tuple<string, string, string>(_.Name, (_.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).FirstOrDefault() as GroupDescriptionAttribute).Description, _.Name.Replace("Controller", "/")));
            ViewBag.Controllers = controllers;
            ViewBag.ControllerCount = controllers.Count();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult FYJKFX()
        {
            ViewBag.Message = "费用监控分析";
            ViewBag.Title = "HospitalReport";
            var controllers = Assembly.GetExecutingAssembly().GetTypes().Where(_ => _.Name.EndsWith("Controller") && _.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).Count() > 0 && (_.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).SingleOrDefault() as GroupDescriptionAttribute).GroupName == "FYJKFX")
                .Select(_ => new Tuple<string, string, string>(_.Name, (_.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).FirstOrDefault() as GroupDescriptionAttribute).Description, _.Name.Replace("Controller", "/")));
            ViewBag.Controllers = controllers;
            return View();
        }

        public ActionResult RCYYFX()
        {
            ViewBag.Message = "日常运行分析";
            ViewBag.Title = "HospitalReport";
            var controllers = Assembly.GetExecutingAssembly().GetTypes().Where(_ => _.Name.EndsWith("Controller") && _.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).Count() > 0 && (_.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).SingleOrDefault() as GroupDescriptionAttribute).GroupName == "RCYYFX")
                .Select(_ => new Tuple<string, string, string>(_.Name, (_.GetCustomAttributes(typeof(GroupDescriptionAttribute), false).FirstOrDefault() as GroupDescriptionAttribute).Description, _.Name.Replace("Controller", "/")));
            ViewBag.Controllers = controllers;
            return View();
        }
    }
}
