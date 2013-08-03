using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class ShoplistingInfo
    {
        public string orderNo { get; set; }
        public string orderDate { get; set; }
        public string orderNum { get; set; }
        public string ConsigneeGuestName { get; set; }
        public string cSCName { get; set; }
        public string ReceivingAddress { get; set; }
        public string Phone { get; set; }
        public string AlipayNo { get; set; }
        public string cmaker { get; set; }
        public string Remark { get; set; }
        public float totalNum { get; set; }
        public float totalPrice { get; set; }
        public string mergerOrderId { get; set; }
        public string orderType { get; set; }


        public string dverifydate { get; set; }

        /// <summary>
        /// 当前打印时间
        /// </summary>
        public string currentTime { get; set; }


    }


}
