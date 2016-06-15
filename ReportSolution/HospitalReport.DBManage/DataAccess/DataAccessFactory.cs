using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalReport.DBManage.DataAccess
{
    public class DataAccessFactory
    {
        public static IDataAccess Instance()
        {
            return Instance("");
        }

        public static IDataAccess Instance(string sqlMapConfig)
        {
            return DataAccessHelp.Create(sqlMapConfig);
        }
    }
}
