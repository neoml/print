using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class ShenTongInfo
    {

        public string Consignee { get; set; }
        public string shopName { get; set; }
        public string cDCName { get; set; }
        public string GetAddress { get; set; }
        public string OrderNum { get; set; }
        public string Phone { get; set; }
        public string StockName { get; set; }
        
        public string OrderNo { get; set; }
        //public string TotalCount { get; set; }
        public int MergerOrderID { get; set; }
        public string salseType { get; set; }
        public string Freight { get; set; }
        

        //单独放日期
        public string RiQi { get; set; }


        //增加大字打印
        public string DaZi { get; set; }


        //增加颜色 尺码 商品代码
        public string YanSe1 { get; set; }
        public string StockCode1 { get; set; }//商品代码
        public string ChiMa1 { get; set; }
        public string Num1 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe2 { get; set; }
        public string StockCode2 { get; set; }//商品代码
        public string ChiMa2 { get; set; }
        public string Num2 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe3 { get; set; }
        public string StockCode3 { get; set; }//商品代码
        public string ChiMa3 { get; set; }
        public string Num3 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe4 { get; set; }
        public string StockCode4 { get; set; }//商品代码
        public string ChiMa4 { get; set; }
        public string Num4 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe5 { get; set; }
        public string StockCode5 { get; set; }//商品代码
        public string ChiMa5 { get; set; }
        public string Num5 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe6 { get; set; }
        public string StockCode6 { get; set; }//商品代码
        public string ChiMa6 { get; set; }
        public string Num6 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe7 { get; set; }
        public string StockCode7 { get; set; }//商品代码
        public string ChiMa7 { get; set; }
        public string Num7 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe8 { get; set; }
        public string StockCode8 { get; set; }//商品代码
        public string ChiMa8 { get; set; }
        public string Num8 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe9 { get; set; }
        public string StockCode9 { get; set; }//商品代码
        public string ChiMa9 { get; set; }
        public string Num9 { get; set; }
        //增加颜色 尺码 商品代码
        public string YanSe0 { get; set; }
        public string StockCode0 { get; set; }//商品代码
        public string ChiMa0 { get; set; }
        public string Num0 { get; set; }
        /// <summary>
        /// 到达方式 如:标准快递 ，当日达 等 (全峰扩展属性)
        /// </summary>
        public string GetWay { get; set; }


        /// <summary>
        /// 寄件付款 (全峰扩展属性)
        /// </summary>
        public string ShippingPayment{ get; set; }

        /// <summary>
        /// 收件付款 (全峰扩展属性)
        /// </summary>
        public string PickupPayment { get; set; }



        /// <summary>
        /// 备注(全峰扩展属性)
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 签收回单(全峰扩展属性)
        /// </summary>
        public string Receipt { get; set; }

        /// <summary>
        /// 总金额(全峰扩展属性)
        /// </summary>
        public string TotalPrice { get; set; }


        /// <summary>
        /// tid(淘宝货到付款扩展属性)
        /// </summary>
        public string Tid { get; set; }


        /// <summary>
        /// 快递方式(淘宝货到付款扩展属性)
        /// </summary>
        public string cSCName { get; set; }

        /// <summary>
        /// 淘宝id(淘宝货到付款扩展属性)
        /// </summary>
        public string GuestName { get; set; }

        /// <summary>
        /// 省市区(淘宝货到付款扩展属性)
        /// </summary>
        public string Province { get; set; }


        /// <summary>
        /// 面单信息
        /// </summary>
        public string ExpressMessage { get; set; }

        /// <summary>
        /// 韵达快运目的城市
        /// </summary>
        public string City
        {
            get; set;
        }

    }
}
