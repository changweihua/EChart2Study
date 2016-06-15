using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
   [GroupDescription(GroupName = "RCYYFX", Description = "再入院")]
    public class ZRYController : Controller
    {
        //
        // GET: /ZRY/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData1()
        {
            var obj = new
            {
                legends = new List<string> { "出院当天再入院人数","2-15天重返","16-31天重返" },
                series = new List<object> {
                    new {
                        name = "出院当天再入院人数",
                        data = new List<double>{ 2,3,5,0,1,1,1,4 }
                    },
                    new {
                        name = "2-15天重返",
                        data = new List<double>{ 7,12,15,7,0,11,13,20 }
                    },
                    new {
                        name = "16-31天重返",
                        data = new List<double>{ 0,0,0,0,1,0,0,0 }
                    }
                },
                categories = new List<string> { "01-01", "01-02", "01-03", "01-04", "01-05", "01-06", "01-07", "01-08" }
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
