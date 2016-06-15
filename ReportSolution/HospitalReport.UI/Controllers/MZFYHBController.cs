using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "FYJKFX", Description = "门诊费用汇报")]
    public class MZFYHBController : Controller
    {
        //
        // GET: /MZFYHB/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData1()
        {
            var obj = new
            {
                legends = new List<string> { "门诊总金额" },
                series = new List<object> {
                    new {
                        name = "门诊总金额",
                        data = new List<double>{ 1.37,5.58 }
                    }
                },
                categories = new List<string> { "2013", "2014" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData2()
        {
            var obj = new
            {
                legends = new List<string> { "门诊总金额" },
                series = new List<object> {
                    new {
                        name = "门诊总金额",
                        data = new List<double>{ 1.37,3.02 }
                    }
                },
                categories = new List<string> { "10.01.~12.01", "11.01~01.01" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData3()
        {
            var obj = new
            {
                legends = new List<string> { "门诊总金额" },
                series = new List<object> {
                    new {
                        name = "门诊总金额",
                        data = new List<double>{ 1.37,1.58,1.44,3.02,6.66,2.88,3.32,1.49 }
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
                legends = new List<string> { "去年费用", "今年费用" },
                series = new List<object> {
                    new {
                        name = "去年费用",
                        data = new List<double>{ 1.37,1.58,1.44,3.02,6.66,2.88,3.32,1.49 }
                    },
                     new {
                        name = "今年费用",
                        data = new List<double>{ 3.37,2.58,1.04,3.82,6.06,4.88,4.32,3.49 }
                    }
                },
                categories = new List<string> { "门诊1", "门诊2", "门诊3", "门诊4", "门诊5", "门诊6", "门诊7", "门诊8" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
