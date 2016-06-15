using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
   [GroupDescription(GroupName = "RCYYFX", Description = "患者负担")]
    public class HZFDController : Controller
    {
        //
        // GET: /Burden/

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

                series = new List<object> {
                    new {name="费用药占比",data = new List<object>{new {name="费用药占比",value=47.71}}, min=0,max=100}, 
                    new {name="门诊人次药费", data = new List<object> {new {name="门诊人次药费",value=150.71}}, min=0,max=1000},
                    new {name="门诊人次费用", data = new List<object> {new {name="门诊人次费用",value=315.86}}, min=0,max=1000}
                }
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
                legends = new List<string> { "门诊人次费用", "门诊人次药费" },
                series = new List<object>{
                    new  {
                        name = "门诊人次费用",
                        data = new List<double> { 317.26,316.92,321.98,306.29,313.42,319.27 }
                    },
                    new  {
                        name = "门诊人次药费",
                        data = new List<double> { 150.01,144.43,146.12,147.65,161.56,154.31 }
                    }
                },
                categories = new List<string> { "2014-10", "2014-11", "2014-12", "2015-01", "2015-02", "2015-03", "" }
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

                series = new List<object> {
                    new {name="费用药占比",data = new List<object>{new {name="费用药占比",value=40.32}}, min=0,max=100}, 
                    new {name="住院人次药费", data = new List<object> {new {name="住院人次药费",value=4761.15}}, min=0,max=5000},
                    new {name="住院人次费用", data = new List<object> {new {name="住院人次费用",value=11806.7}}, min=0,max=10000}
                }
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
                legends = new List<string> { "住院人次费用","住院人次药费" },
                series = new List<object>{
                    new  {
                        name = "住院人次费用",
                        data = new List<double> { 11407.2,11918.97,12205.92,11666.45,12106.11,11490.45 }
                    },
                    new  {
                        name = "住院人次药费",
                        data = new List<double> { 4588.46,4830.42,4679.93,4806.53,5024.65,4628.11 }
                    }
                },
                categories = new List<string> { "2014-10", "2014-11", "2014-12", "2015-01", "2015-02", "2015-03", "" }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
