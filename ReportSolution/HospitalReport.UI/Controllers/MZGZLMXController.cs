using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "RCYYFX", Description = "门诊工作量明细")]
    public class MZGZLMXController : Controller
    {
        //
        // GET: /MZGZLMX/

        public ActionResult Index()
        {
            ViewBag.PagerData = new List<NameValue>
            {
                new NameValue{ name="1",value=1 }
            };
            return View();
        }

        public ActionResult GetData1(int currentPage)
        {
            return Json(new
            {

                data = new List<object>{
                    new { name=currentPage.ToString(),value=currentPage }
                }

            }, JsonRequestBehavior.AllowGet);
        }

    }
}
