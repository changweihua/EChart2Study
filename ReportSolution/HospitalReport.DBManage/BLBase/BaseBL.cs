using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HospitalReport.DBManage.DataAccess;
using System.Collections;
using HospitalReport.Common.Log;

namespace HospitalReport.DBManage.BLBase
{
    public class BaseBL : HTAbstractBLBaseTransactionLogic
    {
        public static IDataAccess doAccess;
        public BaseBL()
        {
            doAccess = dataAccess;

        }
        public T DBOperation<T>(Func<Hashtable, T> operation, Hashtable inParameter)
        {
            try
            {
                T result = operation(inParameter);
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw ex;
            }
            finally
            {
                this.dataAccess.Close();
            }
        }


        public T DBOperationWithTrans<T>(Func<Hashtable, T> operation, Hashtable inParameter)
        {
            try
            {
                this.dataAccess.BeginTransaction();
                T result = operation(inParameter);
                this.dataAccess.Commit();
                return result;
            }
            catch (Exception ex)
            {
                this.dataAccess.Rollback();
                Logger.Error(ex);
                throw ex;
            }
            finally
            {
                this.dataAccess.Close();
            }
        }
    }
}
