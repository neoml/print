using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class InventoryInfo
    {
        public string shopName { get; set; }
        public string GuestName{get;set;}
        public string orderNum { get; set; }
        public string Remark { get; set; }
        public string mergerOrderId { get; set; }

        public string dverifydate { get; set; }

        /// <summary>
        /// 当前打印时间
        /// </summary>
        public string currentTime { get; set; }

    }
}
