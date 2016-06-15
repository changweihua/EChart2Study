using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "RCYYFX", Description = "病区工作量统计")]
    public class BQGZLController : Controller
    {
        //
        // GET: /BQGZL/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData1(string department, DateTime dtStart, DateTime dtEnd)
        {
            double interval = 1;
            if (dtEnd != DateTime.MinValue && dtStart != DateTime.MinValue)
            {
                interval = (dtEnd - dtStart).TotalDays;
            }
            var obj = new
            {

                series = new List<object> {
                    new {name="平均床位使用率",data = new List<object>{new {name="平均床位使用率",value=47.71}}, min=0,max=100}, 
                    new {name="平均开放床位数", data = new List<object> {new {name="平均开放床位数",value=150.71}}, min=0,max=1000},
                    new {name="平均使用床位数", data = new List<object> {new {name="平均使用床位数",value=315.86}}, min=0,max=1000}
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData2(string department, DateTime dtStart, DateTime dtEnd)
        {
            double interval = 1;
            if (dtEnd != DateTime.MinValue && dtStart != DateTime.MinValue)
            {
                interval = (dtEnd - dtStart).TotalDays;
            }
            var obj = new
            {
                legends = new List<string> { "出院", "入院" },
                data = new List<object> {
                new { name="出院",value=2375 },new { name="入院",value=2225 }
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData3(string department, DateTime dtStart, DateTime dtEnd)
        {
            double interval = 1;
            if (dtEnd != DateTime.MinValue && dtStart != DateTime.MinValue)
            {
                interval = (dtEnd - dtStart).TotalDays;
            }
            var obj = new
            {
                legends = new List<string> { "在院人数" },
                series = new List<object>{
                    new  {
                        name = "在院人数",
                        data = new List<double> { 317.26,316.92,321.98,306.29,313.42,319.27 }
                    }
                },
                categories = new List<string> { "2014-09", "2014-10", "2014-11", "2014-12", "2015-01", "2015-02", "2015-03", "" }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
