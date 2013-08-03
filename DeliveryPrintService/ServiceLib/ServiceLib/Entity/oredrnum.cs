using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLib.Entity
{
    [Serializable]
    public class oredrnum
    {
        public string isprint{get;set;}//打印数量
        public string noprint { get; set; }//未打印数量
        public string outNum { get; set; }//已经出库
        public string count {get;set;} //总数
    }
}
