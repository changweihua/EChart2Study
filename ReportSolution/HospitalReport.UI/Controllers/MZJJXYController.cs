using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
   [GroupDescription(GroupName = "FYJKFX", Description = "门诊经济效益")]
    public class MZJJXYController : Controller
    {
        //
        // GET: /MZJJXY/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData1()
        {
            var obj = new
            {

                series = new List<object> {
                    new {name="门诊人均总费用",data = new List<object>{new {name="门诊人均总费用",value=47.71}}, min=0,max=100}, 
                    new {name="门诊人均诊疗费用", data = new List<object> {new {name="门诊人均诊疗费用",value=150.71}}, min=0,max=1000},
                    new {name="门诊人均药品费用", data = new List<object> {new {name="门诊人均药品费用",value=315.86}}, min=0,max=1000}
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData2()
        {
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


        public ActionResult GetData4()
        {
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
    }
}
