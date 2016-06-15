using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
   [GroupDescription(GroupName = "RCYYFX", Description = "工作负荷")]
    public class GZFHController : Controller
    {
        //
        // GET: /Workload/

        public ActionResult Index()
        {
            ViewBag.ActionName = "工作负荷";
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
                legends = new List<string> { "门诊人次", "急诊人次", "急诊留观", "健康体检" },
                data = new List<NameValue> {
                new NameValue{ name="门诊人次",value=319*interval },new NameValue{ name="急诊人次",value=38*interval },
                new NameValue{ name="急诊留观",value=2*interval },new NameValue{ name="健康体检",value=5*interval }
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
                legends = new List<string> { "入院人次", "出院人次" },
                data = new List<NameValue> {
                new NameValue{ name="入院人次",value=27*interval },new NameValue{ name="出院人次",value=23*interval }
                }
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
                min = 0,
                max = 24 * interval,
                data = new List<NameValue> {
                new NameValue{ name="出院患者实际占用总床日",value=23*interval }
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
                legends = new List<string> { "门诊手术", "住院手术" },
                data = new List<NameValue> {
                new NameValue{ name="门诊手术",value=2*interval },new NameValue{ name="住院手术",value=6*interval }
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}
