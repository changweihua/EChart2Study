using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HospitalReport.IDBAccess;
using HospitalReport.DBManage.BLBase;
using HospitalReport.Model;
using System.Collections;

namespace HospitalReport.DBAccess.Accesses
{
    public class DemoAccess : BaseBL, IDemoAccess
    {
        /// <summary>
        /// 获取DemoList
        /// </summary>
        /// <returns></returns>
        public IList<DemoModel> GetDemoList()
        {
            Hashtable inParameter = new Hashtable();
            Func<Hashtable, IList<DemoModel>> operation = delegate(Hashtable parameter)
            {
                return this.dataAccess.QueryForList<DemoModel>("GetDemoList", parameter);
            };
            return base.DBOperation<IList<DemoModel>>(operation, inParameter);
        }
    }
}
