using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
   [GroupDescription(GroupName = "FYJKFX", Description = "门诊收入分析")]
    public class MZSRController : Controller
    {
        //
        // GET: /MZSR/

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
                legends = new List<string> { "挂号费用", "诊疗费用", "药品费用" },
                data = new List<NameValue> {
                new NameValue{ name="诊疗费用",value=467.16 },new NameValue{ name="药品费用",value=436.99 }, new NameValue{ name="挂号费用",value=7.36 }
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
                legends = new List<string> { "诊疗费用", "药品费用" },
                series = new List<object>{
                    new  {
                        name = "诊疗费用",
                        data = new List<double> { 19.39,44.84,71.31,29.85,69.98,57.2,37.35 }
                    },
                    new  {
                        name = "药品费用",
                        data = new List<double> { 12.95,32.21,33.54,21.34,48.07,47.41,27.95 }
                    }
                },
                categories = new List<string> { "02-26", "03-02", "03-06", "03-10", "03-14", "03-18", "03-22" }
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
                legends = new List<string> { "住院人次费用", "住院人次药费" },
                series = new List<object>{
                    new  {
                        name = "住院人次费用",
                        data = new List<double> { 8743.73,8757,12336.64,7676.37,13889.88,11371.82,10735.37 }
                    },
                    new  {
                        name = "住院人次药费",
                        data = new List<double> { 3500.71,3661.02,3946.68,3471.57,5656.07,5154.31,4609.18 }
                    }
                },
                categories = new List<string> { "02-26", "03-02", "03-06", "03-10", "03-14", "03-18", "03-22" }
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
                legends = new List<string> { "诊疗费用", "药品费用" },
                series = new List<object>{
                    new  {
                        name = "诊疗费用",
                        data = new List<double> { 8743.73,8757,12336.64,7676.37,13889.88,11371.82,10735.37 }
                    },
                    new  {
                        name = "药品费用",
                        data = new List<double> { 3500.71,3661.02,3946.68,3471.57,5656.07,5154.31,4609.18 }
                    }
                },
                categories = new List<string> { "02-26", "03-02", "03-06", "03-10", "03-14", "03-18", "03-22" }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
