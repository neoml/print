using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class listinfo
    {
        public string num1 { get; set; }  //数量
        public string StockCode1 { get; set; } //货号
        public string YanSe1 { get; set; } //颜色
        public string ChiMa1 { get; set; }//尺码
    }
}
