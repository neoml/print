using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using ServiceLib.DA;
using System.Data;
using ServiceLib.Util;
using System.Diagnostics;

namespace ServiceLib.BC
{
    public class StoragePrintBC
    {
        StoragePrintDA da = new StoragePrintDA();
        public int TotalCount = 0;
        public int MergeCount = 0;
        public string OrderNum = string.Empty;

        public DataTable GetHuiZ(int address,DateTime dt)
        {
            return da.GetHuiZ(address,dt);
        }


        public bool UpWTdan(string tid, string lx)
        {
            return da.UpWTdan(tid, lx);
        }

        public DataTable GetWTDan(DateTime dtime)
        {
            return da.GetWTDan(dtime);
        }

        public List<int> GetTNum(DateTime dt)
        {
            return da.GetTNum(dt);
        }


        public bool UpKdFs(string tid, string kdfs)
        {
            return da.UpKdFs(tid, kdfs);
        }


        public DataTable GetNoKdTable(string account, int count)
        {

            return da.GetNoKdTable(account, count);
        }



        public bool RealseLock(string ll)
        {
            return da.RealseLock(ll);
        }



        public DataTable GetPrintGroupBy()
        {
            return da.GetPrintGroupBy();
        }


        #region 获得所有已经打印的订单
        public DataTable GetPrintPart(int fromnum, string orderunm, string kddh, string mjid, string caozuo, DateTime shijian, string hdname, DateTime ddtime, bool pt, bool dt)
        {
            return da.GetPrintPart(fromnum, orderunm, kddh, mjid, caozuo, shijian, hdname, ddtime, pt, dt);
        }

        #endregion


        #region 获得打印参考数目

        public List<int> GetPrintNum(string username, string hdname)
        {
            return da.GetPrintNum(username, hdname);
        }

        #endregion



        #region 获得所有活动名称

        public DataTable GetHdNameAll(string Seller_ID)
        {
            return da.GetHdNameAll(Seller_ID);
        }

        #endregion




        //double12
        #region 获取DispatchList记录

        /// <summary>
        /// 获取DispatchList记录
        /// </summary>
        /// <param name="dverifysystime"></param>
        /// <returns></returns>
        public DataTable GetInvoice(string account, string ShippingMethods, string orderNo, string category, string salestype, int count, string sellernick, string hdname)
        {
            return da.GetInvoice(account, ShippingMethods, orderNo, category, salestype, count, sellernick, hdname);
        }
        #endregion








        #region 检查订单是不是存在

        /// <summary>
        /// 检查订单是不是存在
        /// </summary>
        /// <param name="orderNo"></param>
        /// <returns></returns>

        public bool CheckMergerOrder(string orderNo)
        {
            return da.CheckMergerOrder(orderNo);
        }

        #endregion

        //#region 登录

        ///// <summary>
        ///// 登录
        ///// </summary>
        ///// <param name="userName"></param>
        ///// <param name="passWord"></param>
        ///// <returns></returns>
        //public bool LoginCheck(string userName, string passWord)
        //{
        //    if (da.LoginCheck(userName, passWord))
        //        return true;
        //    else
        //        return false;
        //}

        //#endregion


    }
}