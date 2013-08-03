using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class ShoplistingSubInfo
    {
        public int SerialNo { get; set; }
        public string cPosCode { get; set; }
        public string Stockcode { get; set; }
        public string StockName { get; set; }
        public float Price { get; set; }
        public int ActualDelivery { get; set; }
        public float Money { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Remark { get; set; }
        public string InvCheck { get; set; }
        public int flag { get; set; }
        public string mergerOrderId { get; set; }

    }
}
