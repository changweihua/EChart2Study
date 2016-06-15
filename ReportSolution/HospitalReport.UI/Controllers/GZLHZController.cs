using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "RCYYFX", Description = "门工作量汇总")]
    public class GZLHZController : Controller
    {
        //
        // GET: /GZLHZ/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData1()
        {
            var obj = new
            {
                legends = new List<string> { "人数" },
                series = new List<object> {
                    new {
                        name = "人数",
                        data = new List<int>{ 18175,17110 }
                    }
                },
                categories = new List<string> { "2015-01 - 2015-03", "2016-01 - 2016-03" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetData2()
        {
            var obj = new
            {
                legends = new List<string> { "工作量" },
                series = new List<object> {
                    new {
                        name = "工作量",
                        data = new List<int>{ 3013,2561,2427,2730,949,881,1412,3000 }
                    }
                },
                categories = new List<string> { "03-31", "04-01", "04-42", "04-03", "04-04", "04-05", "04-06", "04-07" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData3()
        {
            var obj = new
            {
                legends = new List<string> { "增长率" },
                series = new List<object> {
                    new {
                        name = "增长率",
                        data = new List<double>{ -8.34,-12,-1.53,12,21,-19,9,18 }
                    }
                },
                categories = new List<string> { "门诊1", "门诊2", "门诊3", "门诊4", "门诊5", "门诊6", "门诊7", "门诊8" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetData4()
        {
            var obj = new
            {
                legends = new List<string> { "去年", "今年" },
                series = new List<object> {
                    new {
                        name = "去年",
                        data = new List<double>{ 5600,3400,2800,3444,4567,2233,2403,5480 }
                    },
                    new {
                        name = "今年",
                        data = new List<double>{ 5400,3456,5460,4532,4565,5464,3409,4390 }
                    }
                },
                categories = new List<string> { "门诊1", "门诊2", "门诊3", "门诊4", "门诊5", "门诊6", "门诊7", "门诊8" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}
