using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Genernal.UI.Models;

namespace Genernal.UI.Controllers
{
    [GroupDescription(GroupName = "RCYYFX", Description = "挂号高峰分析")]
    public class GHGFFXController : Controller
    {
        //
        // GET: /RegistrationAnalysic/

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
                legends = new List<string> { "门诊人次费用" },
                series = new List<object>{
                    new  {
                        name = "门诊人次费用",
                        data = new List<double> { 35,18,12,6,7,161,4004,3968,868,430,2451,1325,89,60,45,45 }
                    }
                },
                categories = new List<string>{
                 "00:00","01:30","30:00","04:30","06:00","07:30","09:00","10:30","12:00","13:30","15:00","16:30","18:00","19:30","21:00","22:30"
                },
                min ="2016/05/20 00:00", 
                max = "2016/05/20 01:30" 
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
                legends = new List<string> { "挂号量" },
                series = new List<object>{
                    new  {
                        name = "挂号量",
                        data = new List<object> {
                            new { date="2016-05-10",value= 2097},new { date="2016-05-11",value= 1358},
                            new { date="2016-05-12",value= 2188},new { date="2016-05-13",value= 1614},
                            new { date="2016-05-14",value= 1611},new { date="2016-05-15",value= 1079},
                            new { date="2016-05-16",value= 1719},new { date="2016-05-17",value= 1579},
                            new { date="2016-05-18",value= 1295},new { date="2016-05-19",value= 1703},
                            new { date="2016-05-20",value= 1402},new { date="2016-05-21",value= 1403},
                            new { date="2016-05-22",value= 1156},new { date="2016-05-23",value= 1463}
                        }
                    }
                },
                categories=new List<string>{"02-26", "02-28","03-02","03-04","03-06","03-08","03-10","03-12","03-14","03-16","03-18","03-20","03-22","03-24",""},
                min = "2016/05/09",
                max = "2016/05/24" 
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
