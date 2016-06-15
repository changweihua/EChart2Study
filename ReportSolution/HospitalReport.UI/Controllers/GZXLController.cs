using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "RCYYFX", Description = "工作效率")]
    public class GZXLController : Controller
    {
        //
        // GET: /Efficiency/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData1(DateTime dtStart, DateTime dtEnd)
        {
            double interval = 1;
            if (dtEnd != DateTime.MinValue && dtStart != DateTime.MinValue)
            {
                interval = (dtEnd - dtStart).TotalDays;
            }
            var obj = new
            {
                legends = new List<string> { "患者平均住院日" },
                data = new List<double> { 10.9, 10.4, 10.8, 11.7, 9.7, 13, 10 },
                categories = new List<string> { "2014-09", "2014-10", "2014-11", "2014-12", "2015-01", "2015-02", "2015-03", "" }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData2(DateTime dtStart, DateTime dtEnd)
        {
            double interval = 1;
            if (dtEnd != DateTime.MinValue && dtStart != DateTime.MinValue)
            {
                interval = (dtEnd - dtStart).TotalDays;
            }
            var obj = new
            {
                legends = new List<string> { "平均床位工作日" },
                data = new List<double> { 11.1, 11, 12, 14, 10.1, 12.4, 11.8 },
                categories = new List<string> { "2014-09", "2014-10", "2014-11", "2014-12", "2015-01", "2015-02", "2015-03", "" }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData3(DateTime dtStart, DateTime dtEnd)
        {
            double interval = 1;
            if (dtEnd != DateTime.MinValue && dtStart != DateTime.MinValue)
            {
                interval = (dtEnd - dtStart).TotalDays;
            }
            var obj = new
            {
                legends = new List<string> { "平均床位使用率" },
                data = new List<double> { 38.5, 40.6, 42.7, 40.3, 40.5, 30.9, 43, 4 },
                categories = new List<string> { "2014-09", "2014-10", "2014-11", "2014-12", "2015-01", "2015-02", "2015-03", "" }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData4(DateTime dtStart, DateTime dtEnd)
        {
            double interval = 1;
            if (dtEnd != DateTime.MinValue && dtStart != DateTime.MinValue)
            {
                interval = (dtEnd - dtStart).TotalDays;
            }
            var obj = new
            {
                legends = new List<string> { "平均床位周转数" },
                data = new List<double> { 1, 1, 1.1, 1.2, 1, 0.8, 1.2 },
                categories = new List<string> { "2014-09", "2014-10", "2014-11", "2014-12", "2015-01", "2015-02", "2015-03", "" }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}
