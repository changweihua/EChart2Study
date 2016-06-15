using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalReport.IService;
using HospitalReport.Common.Log;

namespace HospitalReport.UI.Controllers
{
    public class DemoController : Controller
    {
        private IDemoService demoService;
        public DemoController(IDemoService dService)
        {
            demoService = dService;
        }
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            var model = demoService.GetDemoList();
            return View(model);
        }

    }
}
