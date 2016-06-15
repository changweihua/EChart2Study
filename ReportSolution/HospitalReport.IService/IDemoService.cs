using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HospitalReport.Model;

namespace HospitalReport.IService
{
    public interface IDemoService
    {
        /// <summary>
        /// 获取DemoList
        /// </summary>
        /// <returns></returns>
        IList<DemoModel> GetDemoList();
    }
}
