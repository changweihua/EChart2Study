using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "FYJKFX", Description = "平均医生处方金额")]
    public class PJYSCFController : Controller
    {
        //
        // GET: /PJYSCF/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData1()
        {
            var obj = new
            {
                name = "术前天数",
                data1 = 5010,
                data2 = 4990,
                data3 = 10000
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData2()
        {
            var obj = new
            {
                legends = new List<string> { "处方金额" },
                series = new List<object> {
                    new {
                        name = "处方金额",
                        data = new List<double>{ 1.37,1.58,1.44,3.02,6.66,2.88,3.32,1.49 }
                    }
                },
                categories = new List<string> { "门诊1", "门诊2", "门诊3", "门诊4", "门诊5", "门诊6", "门诊7", "门诊8" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}
