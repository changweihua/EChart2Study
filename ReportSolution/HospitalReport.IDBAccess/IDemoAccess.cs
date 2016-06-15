using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HospitalReport.Model;

namespace HospitalReport.IDBAccess
{
    public interface IDemoAccess
    {
        /// <summary>
        /// 获取DemoList
        /// </summary>
        /// <returns></returns>
        IList<DemoModel> GetDemoList();
    }
}
