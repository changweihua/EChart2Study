using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HospitalReport.IService;
using HospitalReport.Model;
using HospitalReport.IDBAccess;
using HospitalReport.DBAccess.Accesses;

namespace HospitalReport.Service
{
    public class DemoService : BaseService, IDemoService
    {
        private IDemoAccess demoAccess;
        public DemoService(IDemoAccess dAccess)
        {
            demoAccess = dAccess;
        }
        /// <summary>
        /// 获取DemoList
        /// </summary>
        /// <returns></returns>
        public IList<DemoModel> GetDemoList()
        {
            //IDemoAccess da = new DemoAccess();
            return demoAccess.GetDemoList();
            //return null;
        }
    }
}
