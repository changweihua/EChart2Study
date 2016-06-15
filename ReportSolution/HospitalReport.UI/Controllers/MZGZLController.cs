using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "RCYYFX", Description = "门诊工作量")]
    public class MZGZLController : Controller
    {
        //
        // GET: /MZGZL/

        public ActionResult Index()
        {
            return View();
        }

    }
}
