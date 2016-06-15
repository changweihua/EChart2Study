using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "RCYYFX", Description = "资源配置")]
    public class ZYPZController : Controller
    {
        //
        // GET: /DailyAnalysic/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDepartment()
        {
            var obj = new
            {
                legends = new List<string> { "病区", "门诊", "住院", "医技", "行政", "体检" },
                data = new List<NameValue> {
                new NameValue{ name="病区",value=74 },new NameValue{ name="门诊",value=120 },
                new NameValue{ name="住院",value=98 },new NameValue{ name="医技",value=22 },
                new NameValue{ name="行政",value=50 },new NameValue{ name="体检",value=2 }
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployee()
        {
            var obj = new
            {
                legends = new List<string> { "医师", "护理", "医技", "行政", "总数" },
                total = 1254,
                data = new List<NameValue> {
                new NameValue{ name="医师",value=398 },new NameValue{ name="护理",value=509 },
                new NameValue{ name="医技",value=123 },new NameValue{ name="行政",value=224 },
                new NameValue{ name="总数",value=0 }
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetBed()
        {
            var obj = new
            {
                legends = new List<string> { "普通病床", "重症病床", "急诊留观", "床位总数" },
                total = 1137,
                data = new List<NameValue> {
                new NameValue{ name="普通病床",value=1078 },new NameValue{ name="重症病床",value=13 },
                new NameValue{ name="急诊留观",value=46 },new NameValue{ name="床位总数",value=0 }
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
